using WebApplication1.Model.DTO;

namespace WebApplication1.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> VillaList = new List<VillaDTO>
        {

                new VillaDTO { Id = 1, Name = "Tooku",Sqft=100,Occupancy=4 },
                new VillaDTO { Id = 2, Name = "Rok",Sqft=100,Occupancy=4 }

        };
    }
}
