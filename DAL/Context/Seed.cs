namespace DAL.Context
{
    public static class Seed
    {
        public static void Initialize(ApplicationContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            context.SaveChanges();

            // todo: add rest;
        }
    }
}
