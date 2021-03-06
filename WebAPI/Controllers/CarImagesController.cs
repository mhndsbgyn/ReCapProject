﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImagesService;

        public CarImagesController(ICarImageService carImagesService)
        {
            _carImagesService = carImagesService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _carImagesService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("add")]
        [DisableRequestSizeLimit]
        public IActionResult Add([FromForm] CarImagesOperationDto carImagesOperationDto)
        {
            var result = _carImagesService.Add(carImagesOperationDto);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }





    }
}
