using DAL.Entities;

namespace DAL.Context
{
    public static class Seed
    {
        public const string Css = "a";
        public static void Initialize(ApplicationContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
            new() {FirstName = "Carson", LastName="Alexander", Email = "test@test.eu"},
            new() {FirstName = "Meredith",LastName="Alonso", Email = "test@test.eu"},
            new() {FirstName = "Arturo",LastName="Anand", Email = "test@test.eu"}

            };
            foreach (var user in users)
            {
                context.Users.Add(user);
            }

            context.SaveChanges();

            // todo: add rest;
        }
    }
}
