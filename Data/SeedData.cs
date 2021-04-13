using Archive.Models;
using System.Linq;

namespace Archive.Data
{
    public static class SeedData
    {
        public static void Initialize(ArchiveContext context)
        {
            if (!context.Sculpts.Any())
            {
                context.Sculpts.AddRange(
                    new Sculpt
                    {
                        Id = 0,
                        Name = "Squeaky Bone",
                        MakerId = 1
                    },
                    new Sculpt
                    {
                        Id = 0,
                        Name = "Knotted Rope",
                        MakerId = 2
                    }
                );

                context.SaveChanges();
            }
        }
    }
}