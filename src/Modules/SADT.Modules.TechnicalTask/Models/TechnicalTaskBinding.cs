using SADT.Modules.TechnicalTask.Enums;

namespace SADT.Modules.TechnicalTask.Models
{
    public class TechnicalTaskBinding
    {
        public int TransformerPower { get; set; }
        public bool IsTransformerPower { get; set; }

        public PhaseNumber PhaseNumber { get; set; }
        public bool IsPhaseNumber { get; set; }

        public Frequency Frequency { get; set; }
        public bool IsFrequency { get; set; }

        public int VoltageLinearNominalHighVoltage { get; set; }
        public bool IsVoltageLinearNominalHighVoltage { get; set; }

        public int VoltageLinearNominalLowVoltage { get; set; }
        public bool IsVoltageLinearNominalLowVoltage { get; set; }

        public VoltageClass VoltageClassHighVoltage { get; set; }
        public bool IsVoltageClassHighVoltage { get; set; }

        public VoltageClass VoltageClassLowVoltage { get; set; }
        public bool IsVoltageClassLowVoltage { get; set; }

        public ConnectionTypeHighVoltage ConnectionTypeHighVoltage { get; set; }
        public bool IsConnectionTypeHighVoltage { get; set; }

        public ConnectionTypeLowVoltage ConnectionTypeLowVoltage { get; set; }
        public bool IsConnectionTypeLowVoltage { get; set; }

        public GroupType GroupType { get; set; }
        public bool IsGroupType { get; set; }

        public ClimaticPerformance ClimaticPerformance { get; set; }
        public bool IsClimaticPerformance { get; set; }

        public CategoryAccommodation CategoryAccommodation { get; set; }
        public bool IsCategoryAccommodation { get; set; }

        public int UpperOperatingTemperature { get; set; }
        public bool IsUpperOperatingTemperature { get; set; }

        public int LowerOperatingTemperature { get; set; }
        public bool IsLowerOperatingTemperature { get; set; }

        public int StepNumber { get; set; }
        public bool IsStepNumber { get; set; }

        public double StepVoltage { get; set; }
        public bool IsStepVoltage { get; set; }

        public LoadMode LoadMode { get; set; }
        public bool IsLoadMode { get; set; }

        public CoolingMethod CoolingMethod { get; set; }
        public bool IsCoolingMethod { get; set; }

        public EarthquakeIntensity EarthquakeIntensity { get; set; }
        public bool IsEarthquakeIntensity { get; set; }

        public int InstallationAltitude { get; set; }
        public bool IsInstallationAltitude { get; set; }

        public double RatioDeviationMainMinimum { get; set; }
        public bool IsRatioDeviationMainMinimum { get; set; }

        public double RatioDeviationMainMaximum { get; set; }
        public bool IsRatioDeviationMainMaximum { get; set; }

        public double RatioDeviationMinorMinimum { get; set; }
        public bool IsRatioDeviationMinorMinimum { get; set; }

        public double RatioDeviationMinorMaximum { get; set; }
        public bool IsRatioDeviationMinorMaximum { get; set; }

        public int LoadLossesNominal { get; set; }
        public bool IsLoadLossesNominal { get; set; }

        public double LoadLossesDeviationMinimum { get; set; }
        public bool IsLoadLossesDeviationMinimum { get; set; }

        public double LoadLossesDeviationMaximum { get; set; }
        public bool IsLoadLossesDeviationMaximum { get; set; }

        public double ShortCircuitVoltageNominal { get; set; }
        public bool IsShortCircuitVoltageNominal { get; set; }

        public double ShortCircuitVoltageDeviationMinimum { get; set; }
        public bool IsShortCircuitVoltageDeviationMinimum { get; set; }

        public double ShortCircuitVoltageDeviationMaximum { get; set; }
        public bool IsShortCircuitVoltageDeviationMaximum { get; set; }

        public int NoLoadLossesNominal { get; set; }
        public bool IsNoLoadLossesNominal { get; set; }

        public double NoLoadLossesDeviationMinimum { get; set; }
        public bool IsNoLoadLossesDeviationMinimum { get; set; }

        public double NoLoadLossesDeviationMaximum { get; set; }
        public bool IsNoLoadLossesDeviationMaximum { get; set; }

        public double NoLoadCurrentNominal { get; set; }
        public bool IsNoLoadCurrentNominal { get; set; }

        public double NoLoadCurrentDeviationMinimum { get; set; }
        public bool IsNoLoadCurrentDeviationMinimum { get; set; }

        public double NoLoadCurrentDeviationMaximum { get; set; }
        public bool IsNoLoadCurrentDeviationMaximum { get; set; }

        public int TotalLossesNominal { get; set; }
        public bool IsTotalLossesNominal { get; set; }

        public double TotalLossesDeviationMinimum { get; set; }
        public bool IsTotalLossesDeviationMinimum { get; set; }

        public double TotalLossesDeviationMaximum { get; set; }
        public bool IsTotalLossesDeviationMaximum { get; set; }

        public int OilUpperLayersExcessTemperature { get; set; }
        public bool IsOilUpperLayersExcessTemperature { get; set; }

        public int WindingHighVoltageExcessTemperature { get; set; }
        public bool IsWindingHighVoltageExcessTemperature { get; set; }

        public int WindingLowVoltageExcessTemperature { get; set; }
        public bool IsWindingLowVoltageExcessTemperature { get; set; }

        public int SystemMagneticExcessTemperature { get; set; }
        public bool IsSystemMagneticExcessTemperature { get; set; }

        public int StructuralElementsExcessTemperature { get; set; }
        public bool IsStructuralElementsExcessTemperature { get; set; }

        public InsulationMode InsulationMode { get; set; }
        public bool IsInsulationMode { get; set; }

        public InternalInsulation InternalInsulation { get; set; }
        public bool IsInternalInsulation { get; set; }

        public ExternalInsulation ExternalInsulation { get; set; }
        public bool IsExternalInsulation { get; set; }

        public int TestPKPNHighVoltage { get; set; }
        public bool IsTestPKPNHighVoltage { get; set; }

        public int TestPKPNLowVoltage { get; set; }
        public bool IsTestPKPNLowVoltage { get; set; }

        public int TestIKPNHighVoltage { get; set; }
        public bool IsTestIKPNHighVoltage { get; set; }

        public int TestIKPNLowVoltage { get; set; }
        public bool IsTestIKPNLowVoltage { get; set; }

        public int TestLI1HighVoltage { get; set; }
        public bool IsTestLI1HighVoltage { get; set; }

        public int TestLI1LowVoltage { get; set; }
        public bool IsTestLI1LowVoltage { get; set; }

        public int TestLI3HighVoltage { get; set; }
        public bool IsTestLI3HighVoltage { get; set; }

        public int TestLI3LowVoltage { get; set; }
        public bool IsTestLI3LowVoltage { get; set; }

        public int TestSI1HighVoltage { get; set; }
        public bool IsTestSI1HighVoltage { get; set; }

        public int TestSI1LowVoltage { get; set; }
        public bool IsTestSI1LowVoltage { get; set; }

        public int TestPKPNExHighVoltage { get; set; }
        public bool IsTestPKPNExHighVoltage { get; set; }

        public int TestPKPNExLowVoltage { get; set; }
        public bool IsTestPKPNExLowVoltage { get; set; }

        public int TestLI1ExHighVoltage { get; set; }
        public bool IsTestLI1ExHighVoltage { get; set; }

        public int TestLI1ExLowVoltage { get; set; }
        public bool IsTestLI1ExLowVoltage { get; set; }
    }
}
