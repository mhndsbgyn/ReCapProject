﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

      
      public  IDataResult<List<Color>> GetAll()
        {
              if (DateTime.Now.Hour == 11)
            {
                return new ErrorDataResult<List<Color>>(Messages.MaintenanceTime);

            }
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }
    }
}
