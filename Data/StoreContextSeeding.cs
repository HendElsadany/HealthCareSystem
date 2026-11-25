using HealthCareSystem.Entities;

namespace HealthCareSystem.Data
{
    public static class StoreContextSeeding
    {
        public static async Task SeedAsync(ApplicationDbContext context)
        {
            if (!context.Doctors.Any())
            {
                context.Doctors.AddRange(
                    new Doctor { Name = "Dr. Ahmed", Specialization = "Cardiology" },
                    new Doctor { Name = "Dr. Sara", Specialization = "Dermatology" });
            }

            if (!context.Patients.Any())
            {
                context.Patients.AddRange(
                    new Patient { Name = "Mohamed", DateOfBirth = new DateTime(1995, 5, 10) },
                    new Patient { Name = "Mona", DateOfBirth = new DateTime(2000, 8, 20) });
            }

            await context.SaveChangesAsync();
        }
    }
}