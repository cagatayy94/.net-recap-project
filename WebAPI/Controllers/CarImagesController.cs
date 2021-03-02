using System;
using System.IO;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;
        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm] CarImage carImage)
        {
            var imageName = Guid.NewGuid();
            var image = carImage.Image;
            if (image.Length > 0)
            {
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot/images", imageName + ".png");
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    image.CopyTo(fileStream);
                }
            };

            carImage.ImagePath = imageName + ".png";

            carImage.Date = DateTime.Now;

            var result = _carImageService.Add(carImage);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update([FromForm] CarImage carImage)
        {
            var imageName = Guid.NewGuid();
            var image = carImage.Image;
            if (image.Length > 0)
            {
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot/images", imageName + ".png");
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    image.CopyTo(fileStream);
                }
            };

            carImage.ImagePath = imageName + ".png";
            carImage.Date = DateTime.Now;

            var result = _carImageService.Update(carImage);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(int carImgId)
        {
            var result = _carImageService.Delete(carImgId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getimagesbycarid")]
        public IActionResult GetCarImagesByCarId(int carId)
        {
            var result = _carImageService.GetCarImagesByCarId(carId);
            if (result.Success)
            {
                if (result.Data.Count == 0)
                {
                    CarImage carImage = new CarImage();
                    carImage.ImagePath = "default.png";
                    carImage.CarId = carId;
                    result.Data.Add(carImage);

                }
                return Ok(result);
            }

            return BadRequest(result);
        }

    }
}
