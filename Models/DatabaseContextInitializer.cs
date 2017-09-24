using System.Data.Entity;
using System.Linq;

namespace Models
{
    internal class DatabaseContextInitializer :
        System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        public DatabaseContextInitializer()
        {

        }

        protected override void Seed(DatabaseContext databaseContext)
        {
            base.Seed(databaseContext);

            try
            {
                Models.User oAdminUser = new Models.User();

                oAdminUser.IsAdmin = true;
                oAdminUser.IsActive = true;

                oAdminUser.Username = "Dariush";
                oAdminUser.Password = "1234512345";
                oAdminUser.FullName = "Mr. Dariush Tasdighi";

                databaseContext.Users.Add(oAdminUser);
            }
            catch (System.Exception)
            {

            }
        }
    }
}
