using Verivox.TariffComparator.Models.Models;
using Verivox.TariffComparator.Service.Contracts;

namespace Verivox.TariffComparator.Test.TariffComparatorTests
{
    public class TariffComparatorTest
    {
        private readonly ITariffComparator _mockTariffComparator;
        public TariffComparatorTest()
        {
            _mockTariffComparator = new Service.Services.TariffComparator(new Service.Factories.TariffTypeFactory());
        }
        [Fact]
        public void CalculateAnnualCosts_WhenSingleUnknownTariffProvided_ReturnsSingleAnnualCostWithValidCalculation()
        {
            //Arrange
            var mockTariffs = new List<Tariff>
            {
                new Tariff
                {
                   Name = "MockProdUnknown" ,
                   Type =99,
                   BaseCost = 5,
                   AdditionalKwhCost =22
                }
            };
            var consumedKwh = 3500;

            //Act
            var result_for_unknown_type = _mockTariffComparator.CalculateAnnualCosts(consumedKwh, mockTariffs);

            //Assert
            Assert.Equal(1, result_for_unknown_type.Count);
            Assert.Equal("Unknown Tariff Plan Type Provided", result_for_unknown_type.FirstOrDefault().Message);
        }
        [Fact]
        public void CalculateAnnualCosts_WhenMultipleTariffsProvided_ReturnsMultipleAnnualCostWithValidCalculation()
        {
            //Arrange
            var mockTariffs = new List<Tariff>
            {
                new Tariff
                {
                   Name = "MockProdA" ,
                   Type =1,
                   BaseCost = 5,
                   AdditionalKwhCost =22
                },
                new Tariff
                {
                   Name = "MockProdB" ,
                   Type =2,
                   IncludedKwh = 4000,
                   BaseCost = 800,
                   AdditionalKwhCost =30
                }
            };
            var consumedKwhBelowThreshold = 3500;
            var consumedKwhAboveThreshold = 4500;
            //Act
            var result_for_below_threshold_consumption = _mockTariffComparator.CalculateAnnualCosts(consumedKwhBelowThreshold, mockTariffs);
            var result_for_above_threshold_consumption = _mockTariffComparator.CalculateAnnualCosts(consumedKwhAboveThreshold, mockTariffs);

            //Assert
            Assert.Equal(2, result_for_below_threshold_consumption.Count);
            Assert.Equal(2, result_for_above_threshold_consumption.Count);
            Assert.Equal(800, result_for_below_threshold_consumption.FirstOrDefault().AnnualCost);
            Assert.Equal(830, result_for_below_threshold_consumption.LastOrDefault().AnnualCost);
            Assert.Equal(950, result_for_above_threshold_consumption.FirstOrDefault().AnnualCost);
            Assert.Equal(1050, result_for_above_threshold_consumption.LastOrDefault().AnnualCost);
        }
        [Fact]
        public void CalculateAnnualCosts_WhenSingleTariffProvided_ReturnsSingleAnnualCostWithValidCalculation()
        {
            var mockTariffs = new List<Tariff>
            {
                new Tariff
                {
                   Name = "MockProdB" ,
                   Type =2,
                   IncludedKwh = 4000,
                   BaseCost = 800,
                   AdditionalKwhCost =30
                }
            };
            var consumedKwhBelowThreshold = 3500;
            var consumedKwhAboveThreshold = 4500;
            //Act
            var result_for_below_threshold_consumption = _mockTariffComparator.CalculateAnnualCosts(consumedKwhBelowThreshold, mockTariffs);
            var result_for_above_threshold_consumption = _mockTariffComparator.CalculateAnnualCosts(consumedKwhAboveThreshold, mockTariffs);

            //Assert
            Assert.Equal(1, result_for_below_threshold_consumption.Count);
            Assert.Equal(1, result_for_above_threshold_consumption.Count);
            Assert.Equal(800, result_for_below_threshold_consumption.FirstOrDefault().AnnualCost);
            Assert.Equal(950, result_for_above_threshold_consumption.FirstOrDefault().AnnualCost);
        }
    }
}
