using Domain.Entities.Project;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BackEnd_Persistence.SeedData
{
    class SeedProperty : IEntityTypeConfiguration<Property>
    {
        void IEntityTypeConfiguration<Property>.Configure(EntityTypeBuilder<Property> builder)
        {
            builder.HasData(
                new Property
                {
                    Id = 1,
                    FeatureImage = "ph1.jpg",
                    OwnerPhoneNumber = "09123071411",
                    AgentPhoneNmber = "09123071411",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    PaymentPlan = "70% پیش پرداخت",
                    KeyHandOverDate = DateTime.Now,
                    Price = 102000,
                    VATFee = 7000,
                    ConnectionFee = 2300,
                    StampDutyFee = 200,
                    Address = "لانگ بیج",
                    NumberOfBedroom = 0,
                    NumberOfBathroom = 1,
                    FloorSpace = 55,
                    Floor = 2,
                    Description = "",
                    PropertyStatus = true,//available or no
                    PropertyTypeId = 1,
                    CityId = 3,
                    PropertyContractTypeId = 1

                },
                new Property
                {
                    Id = 2,
                    FeatureImage = "ph2.jpg",
                    OwnerPhoneNumber = "09123071411",
                    AgentPhoneNmber = "09123071411",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    PaymentPlan = "70% پیش پرداخت",
                    KeyHandOverDate = DateTime.Now,
                    Price = 160000,
                    VATFee = 7000,
                    ConnectionFee = 2300,
                    StampDutyFee = 200,
                    Address = "لانگ بیج",
                    NumberOfBedroom = 1,
                    NumberOfBathroom = 1,
                    FloorSpace = 64,
                    Floor = 2,
                    Description = "",
                    PropertyStatus = true,//available or no
                    PropertyTypeId = 1,
                    CityId = 3,
                    PropertyContractTypeId = 1
                },
                new Property
                {
                    Id = 3,
                    FeatureImage = "ph3.jpg",
                    OwnerPhoneNumber = "09123071411",
                    AgentPhoneNmber = "09123071411",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    PaymentPlan = "70% پیش پرداخت",
                    KeyHandOverDate = DateTime.Now,
                    Price = 325000,
                    VATFee = 7000,
                    ConnectionFee = 2300,
                    StampDutyFee = 200,
                    Address = "لانگ بیج",
                    NumberOfBedroom = 3,
                    NumberOfBathroom = 2,
                    FloorSpace = 125,
                    Floor = 0,
                    Description = "",
                    PropertyStatus = true,//available or no
                    PropertyTypeId = 2,
                    CityId = 4,
                    PropertyContractTypeId = 3
                },
                new Property
                {
                    Id = 4,
                    FeatureImage = "ph4.jpg",
                    OwnerPhoneNumber = "09123071411",
                    AgentPhoneNmber = "09123071411",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    PaymentPlan = "ماهیانه",
                    KeyHandOverDate = DateTime.Now,
                    Price = 8450,
                    VATFee = 0,
                    ConnectionFee = 0,
                    StampDutyFee = 0,
                    Address = "لانگ بیج",
                    NumberOfBedroom = 1,
                    NumberOfBathroom = 1,
                    FloorSpace = 65,
                    Floor = 3,
                    Description = "",
                    PropertyStatus = true,//available or no
                    PropertyTypeId = 1,
                    CityId = 3,
                    PropertyContractTypeId = 2
                },
                new Property
                {
                    Id = 5,
                    FeatureImage = "ph5.jpg",
                    OwnerPhoneNumber = "09123071411",
                    AgentPhoneNmber = "09123071411",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    PaymentPlan = "20% پیش پرداخت - ",
                    KeyHandOverDate = DateTime.Now,
                    Price = 26000,
                    VATFee = 2000,
                    ConnectionFee = 1500,
                    StampDutyFee = 250,
                    Address = "لانگ بیج",
                    NumberOfBedroom = 0,
                    NumberOfBathroom = 1,
                    FloorSpace = 48,
                    Floor = 15,
                    Description = "",
                    PropertyStatus = true,//available or no
                    PropertyTypeId = 1,
                    CityId = 3,
                    PropertyContractTypeId = 3
                }
                );
        }
    }
}
