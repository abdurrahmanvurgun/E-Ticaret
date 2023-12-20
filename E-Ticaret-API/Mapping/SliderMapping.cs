using AutoMapper;
using DTOLayer.SliderDto;
using E_Ticaret.EntityLayer.Entities;


namespace E_Ticaret.Mapping
{
	public class SliderMapping:Profile
	{
        public SliderMapping()
        {
			CreateMap<Slider, ResultSliderDto>().ReverseMap();
		}
    }
}
