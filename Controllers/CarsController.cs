using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;
using System.Diagnostics;
namespace MyWebApp.Controllers
{
    public class CarsController : Controller
    {
        int number = 10;
        public List<Cars> cars = new List<Cars>
{
            new Cars { Name = "Toyota Camry", color = "Blue", description = "Reliable midsize sedan", modelNumber = "CAM2025", fuletype = "Petrol",imageURL="https://static.pakwheels.com/2023/11/rt.jpg" },
            new Cars { Name = "Honda Civic", color = "Black", description = "Compact and fuel-efficient", modelNumber = "CIV2024", fuletype = "Petrol",imageURL="https://media.ed.edmunds-media.com/honda/civic/2026/oem/2026_honda_civic_sedan_si_fq_oem_1_1280.jpg" },
            new Cars { Name = "Tesla Model 3", color = "Black", description = "Electric sedan with autopilot", modelNumber = "TM32025", fuletype = "Electric",imageURL="https://media.drivingelectric.com/image/private/s--X-WVjvBW--/f_auto,t_content-image-full-desktop@1/v1698686429/drivingelectric/2023-10/Tesla%20Model%203%20facelift%201_awovfc.jpg" },
            new Cars { Name = "Ford F-150", color = "Grey", description = "Best-selling pickup truck", modelNumber = "F150XLT", fuletype = "Diesel" ,imageURL="https://www.topgear.com/sites/default/files/2024/05/1-Ford-F-150-review.jpg" },
            new Cars { Name = "Chevrolet Bolt", color = "Silver", description = "Affordable electric car", modelNumber = "BOLT-EV", fuletype = "Electric",imageURL="https://www.chevrolet.ca/content/dam/chevrolet/na/canada/english/index/bolt-stay-tuned/Bolt_StayTuned_Masthead_2500x1000.png" },
            new Cars { Name = "BMW X5", color = "Gray", description = "Luxury midsize SUV", modelNumber = "X52025", fuletype = "Petrol",imageURL="https://images.prismic.io/carwow/aApA-vIqRLdaBlBi_BMWX52025exteriorfrontthreequarterviewdriving.jpg" },
            new Cars { Name = "Audi A4", color = "Blue", description = "Premium compact sedan", modelNumber = "A4-QUATTRO", fuletype = "Petrol",imageURL="https://www.topgear.com/sites/default/files/cars-car/image/2021/03/audiuk0002282120audi20a420saloon.jpg" },
            new Cars { Name = "Hyundai Ioniq 5", color = "Gray", description = "Futuristic EV crossover", modelNumber = "IONIQ5", fuletype = "Electric",imageURL="https://ev-database.org/img/auto/Hyundai_IONIQ5_2021/Hyundai_IONIQ5_2021-01.jpg" },
            new Cars { Name = "Kia Sportage", color = "Gray", description = "Sporty compact SUV", modelNumber = "SPORT2025", fuletype = "Petrol",imageURL="https://cdn.motor1.com/images/mgl/AkNqeN/s3/2025-kia-sportage-south-korea.jpg" },
            new Cars { Name = "Jeep Wrangler", color = "Blue", description = "Off-road adventure SUV", modelNumber = "WRANGLER-RUBI", fuletype = "Diesel" ,imageURL="https://www.topgear.com/sites/default/files/2024/04/1-Jeep-Wrangler-review-2024.jpg" }
            };
        public IActionResult Selection()
        {
            return View(cars);
        }
        public IActionResult Descript(int id)
        {
            
            return View(cars[id]);
        }
        
    }
}
