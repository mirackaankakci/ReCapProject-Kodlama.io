using Business.Abstract;
using Business.Constans;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IDataResult<List<Color>> getAllColor()
        {
            return new SuccessDataResult<List<Color>>(Messages.ColorList);
        }

        public IDataResult<Color> GetColor(int colorId)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.Id == colorId),Messages.ColorList);
        }

        public IResult Remove(Color color)
        {
            _colorDal.Delete(color);
            
            return new SuccessResult(Messages.ColorDelented);
        }

        public IResult Update(Color color)
        {
           _colorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdate);
        }
    }
}
