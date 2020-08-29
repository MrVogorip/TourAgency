using AutoMapper;
using System.Collections.Generic;
using TourAgency.Bll.DTO;
using TourAgency.Web.Models;

namespace TourAgency.Web.Helpers
{
    public static class MappingViewModel
    {
        private static MapperConfiguration _mapperConfiguration = new MapperConfiguration(cfg =>
        {
            cfg.AllowNullCollections = true;
            cfg.CreateMap<AdministratorViewModel, AdministratorDTO>();
            cfg.CreateMap<ApplicationUserViewModel, ApplicationUserDTO>();
            cfg.CreateMap<CityViewModel, CityDTO>();
            cfg.CreateMap<CustomerViewModel, CustomerDTO>();
            cfg.CreateMap<FeedbackViewModel, FeedbackDTO>();
            cfg.CreateMap<ManagerViewModel, ManagerDTO>();
            cfg.CreateMap<TourViewModel, TourDTO>();
            cfg.CreateMap<TourCustomerViewModel, TourCustomerDTO>();
            cfg.CreateMap<TypeOfHotelViewModel, TypeOfHotelDTO>();
            cfg.CreateMap<TypeOfStatusViewModel, TypeOfStatusDTO>();
            cfg.CreateMap<TypeOfTourViewModel, TypeOfTourDTO>();
        });
        private static MapperConfiguration _mapperConfigurationViewModel = new MapperConfiguration(cfg =>
        {
            cfg.AllowNullCollections = true;
            cfg.CreateMap<AdministratorDTO, AdministratorViewModel>();
            cfg.CreateMap<ApplicationUserDTO, ApplicationUserViewModel>();
            cfg.CreateMap<CityDTO, CityViewModel>();
            cfg.CreateMap<CustomerDTO, CustomerViewModel>();
            cfg.CreateMap<FeedbackDTO, FeedbackViewModel>();
            cfg.CreateMap<ManagerDTO, ManagerViewModel>();
            cfg.CreateMap<TourDTO, TourViewModel>();
            cfg.CreateMap<TourCustomerDTO, TourCustomerViewModel>();
            cfg.CreateMap<TypeOfHotelDTO, TypeOfHotelViewModel>();
            cfg.CreateMap<TypeOfStatusDTO, TypeOfStatusViewModel>();
            cfg.CreateMap<TypeOfTourDTO, TypeOfTourViewModel>();
        });
        public static CustomerDTO MapCustomerDTO(CustomerViewModel customer)
        {
            var configuration = _mapperConfiguration;
            var mapper = configuration.CreateMapper();
            var customerDTO = mapper.Map<CustomerViewModel, CustomerDTO>(customer);
            return customerDTO;
        }
        public static CustomerViewModel MapCustomerViewModel(CustomerDTO customer)
        {
            var configuration = _mapperConfigurationViewModel;
            var mapper = configuration.CreateMapper();
            var customerViewModel = mapper.Map<CustomerDTO, CustomerViewModel>(customer);
            return customerViewModel;
        }

        public static ManagerDTO MapManagerDTO(ManagerViewModel manager)
        {
            var configuration = _mapperConfiguration;
            var mapper = configuration.CreateMapper();
            var managerDto = mapper.Map<ManagerViewModel, ManagerDTO>(manager);
            return managerDto;
        }

        public static List<CustomerViewModel> MapCustomerListViewModel(List<CustomerDTO> customers)
        {
            var configuration = _mapperConfigurationViewModel;
            var mapper = configuration.CreateMapper();
            var customersViewModel = mapper.Map<List<CustomerDTO>, List<CustomerViewModel>>(customers);
            return customersViewModel;
        }
        public static TypeOfStatusViewModel MapTypeOfStatusViewModel(TypeOfStatusDTO typeOfStatus)
        {
            var config = _mapperConfigurationViewModel;
            var mapper = new Mapper(config);
            var typeOfStatusViewModel = mapper.Map<TypeOfStatusViewModel>(typeOfStatus);
            return typeOfStatusViewModel;
        }
        public static TourDTO MapTourDTO(TourViewModel tour)
        {
            var configuration = _mapperConfiguration;
            var mapper = configuration.CreateMapper();
            var toursDTO = mapper.Map<TourViewModel, TourDTO>(tour);
            return toursDTO;
        }
        public static List<TourDTO> MapTourListDTO(List<TourViewModel> tours)
        {
            var configuration = _mapperConfiguration;
            var mapper = configuration.CreateMapper();
            var toursDTO = mapper.Map<List<TourViewModel>, List<TourDTO>>(tours);
            return toursDTO;
        }

        public static List<ManagerViewModel> MapManagerListViewModel(List<ManagerDTO> managers)
        {
            var configuration = _mapperConfigurationViewModel;
            var mapper = configuration.CreateMapper();
            var managersViewModel = mapper.Map<List<ManagerDTO>, List<ManagerViewModel>>(managers);
            return managersViewModel;
        }

        public static TourViewModel MapTourViewModel(TourDTO tour)
        {
            var configuration = _mapperConfigurationViewModel;
            var mapper = configuration.CreateMapper();
            var toursViewModel = mapper.Map<TourDTO, TourViewModel>(tour);
            return toursViewModel;
        }
        public static List<TourViewModel> MapTourListViewModel(List<TourDTO> tours)
        {
            var configuration = _mapperConfigurationViewModel;
            var mapper = configuration.CreateMapper();
            var toursViewModel = mapper.Map<List<TourDTO>, List<TourViewModel>>(tours);
            return toursViewModel;
        }
        public static List<TourCustomerViewModel> MapTourCustomerListViewModel(List<TourCustomerDTO> toursCustomer)
        {
            var configuration = _mapperConfigurationViewModel;
            var mapper = configuration.CreateMapper();
            var toursCustomerViewModel = mapper.Map<List<TourCustomerDTO>, List<TourCustomerViewModel>>(toursCustomer);
            return toursCustomerViewModel;
        }

        public static TourCustomerDTO MapTourCustomerDTO(TourCustomerViewModel tourCustomer)
        {
            var configuration = _mapperConfiguration;
            var mapper = configuration.CreateMapper();
            var toursCustomerDTO = mapper.Map<TourCustomerViewModel, TourCustomerDTO>(tourCustomer);
            return toursCustomerDTO;
        }
        public static TypeOfHotelDTO MapTypeOfHotelDTO(TypeOfHotelViewModel typeOfHotel)
        {
            var configuration = _mapperConfiguration;
            var mapper = configuration.CreateMapper();
            var typeOfHotelDTO = mapper.Map<TypeOfHotelViewModel, TypeOfHotelDTO>(typeOfHotel);
            return typeOfHotelDTO;
        }
        public static TypeOfTourDTO MapTypeOfTourDTO(TypeOfTourViewModel typeOfTour)
        {
            var configuration = _mapperConfiguration;
            var mapper = configuration.CreateMapper();
            var typeOfTourDTO = mapper.Map<TypeOfTourViewModel, TypeOfTourDTO>(typeOfTour);
            return typeOfTourDTO;
        }
        public static CityDTO MapCityDTO(CityViewModel city)
        {
            var configuration = _mapperConfiguration;
            var mapper = configuration.CreateMapper();
            var cityDTO = mapper.Map<CityViewModel, CityDTO>(city);
            return cityDTO;
        }
        public static FeedbackDTO MapFeedbackDTO(FeedbackViewModel feedback)
        {
            var configuration = _mapperConfiguration;
            var mapper = configuration.CreateMapper();
            var feedbackDTO = mapper.Map<FeedbackViewModel, FeedbackDTO>(feedback);
            return feedbackDTO;
        }
        public static FeedbackViewModel MapFeedbackViewModel(FeedbackDTO feedbackDTO)
        {
            var configuration = _mapperConfigurationViewModel;
            var mapper = configuration.CreateMapper();
            var feedback = mapper.Map<FeedbackDTO, FeedbackViewModel>(feedbackDTO);
            return feedback;
        }
        public static List<FeedbackViewModel> MapFeedbackListViewModel(List<FeedbackDTO> feedbacksDTO)
        {
            var configuration = _mapperConfigurationViewModel;
            var mapper = configuration.CreateMapper();
            var feedbacks = mapper.Map<List<FeedbackDTO>, List<FeedbackViewModel>>(feedbacksDTO);
            return feedbacks;
        }
        public static List<FeedbackDTO> MapFeedbackListDTO(List<FeedbackViewModel> feedbacks)
        {
            var configuration = _mapperConfiguration;
            var mapper = configuration.CreateMapper();
            var feedbacksDTO = mapper.Map<List<FeedbackViewModel>, List<FeedbackDTO>>(feedbacks);
            return feedbacksDTO;
        }
    }
}