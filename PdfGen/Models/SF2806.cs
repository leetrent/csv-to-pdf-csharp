using ChoETL;

namespace PdfGen.Models
{
   class SF2806
    {
        [PdfFieldAttribute("NAME-1")]
        [ChoCSVRecordField(1, FieldName = "NAME")]
        public string Name1 { get; set; }

        [PdfFieldAttribute("DOB_MONTH")]
        [ChoCSVRecordField(2, FieldName = "DOB1")]
        public string DateOfBirth1 { get; set; }

        [PdfFieldAttribute("DOB_DAY")]
        [ChoCSVRecordField(3, FieldName = "DOB2")]
        public string DateOfBirth2 { get; set; }

        [PdfFieldAttribute("DOB_YEAR")]
        [ChoCSVRecordField(4, FieldName = "DOB3")]
        public string DateOfBirth3 { get; set; }

        [PdfFieldAttribute("SSN-1")]
        [ChoCSVRecordField(5, FieldName = "SSN1")]
        public string SocialSecurity1 { get; set; }

        [PdfFieldAttribute("SSN-2")]
        [ChoCSVRecordField(6, FieldName = "SSN2")]
        public string SocialSecurity2 { get; set; }

        [PdfFieldAttribute("SSN-3")]
        [ChoCSVRecordField(7, FieldName = "SSN3")]
        public string SocialSecurity3 { get; set; }

        [PdfFieldAttribute("AGENCY-1")]
        [ChoCSVRecordField(8, FieldName = "AGENCY")]
        public string Agency1 { get; set; }

        [PdfFieldAttribute("PAYROLL_OFFICE-1")]
        [ChoCSVRecordField(9, FieldName = "PAYROLL OFFICE")]
        public string PayrollOffice { get; set; }

        [PdfFieldAttribute("LOCATION-1")]
        [ChoCSVRecordField(10, FieldName = "LOCATION")]
        public string Location { get; set; }

        [PdfFieldAttribute("PAYROLL_OFFICE_NO-1")]
        [ChoCSVRecordField(11, FieldName = "TSN")]
        public string PayrollOfficeNumber { get; set; }

        [PdfFieldAttribute("NAME-2")]
        [ChoCSVRecordField(12, FieldName = "NAME2")]
        public string Name2 { get; set; }

        [PdfFieldAttribute("NAME-3")]
        [ChoCSVRecordField(13, FieldName = "NAME3")]
        public string Name3 { get; set; }

        [PdfFieldAttribute("NAME-4]")]
        [ChoCSVRecordField(14, FieldName = "NAME4")]
        public string Name4 { get; set; }

        [PdfFieldAttribute("EFFECTIVE_DATE-1")]
        [ChoCSVRecordField(15, FieldName = "EFFECTIVE DATE1")]
        public string EffectiveDate1 { get; set; }

        [PdfFieldAttribute("ACTION-1")]
        [ChoCSVRecordField(16, FieldName = "ACTION1")]
        public string Action1 { get; set; }

        [PdfFieldAttribute("BASE_PAY-1")]
        [ChoCSVRecordField(17, FieldName = "BASE PAY1")]
        public string BasePay1 { get; set; }

        [PdfFieldAttribute("SH_REMARKS-1")]
        [ChoCSVRecordField(18, FieldName = "REMARKS1A")]
        public string ServiceHistRemarks1 { get; set; }

        [PdfFieldAttribute("YEAR-1")]
        [ChoCSVRecordField(19, FieldName = "YEAR1")]
        public string Year1 { get; set; }

        [PdfFieldAttribute("CY_SALARY_DEDUCTIONS-1")]
        [ChoCSVRecordField(20, FieldName = "CY SAL DED1")]
        public string CYSalaryDeductions1 { get; set; }

        [PdfFieldAttribute("ACCUM_SAL_DEDUCTIONS-1")]
        [ChoCSVRecordField(21, FieldName = "ACC SAL DED1")]
        public string AccSalaryDeductions1 { get; set; }

        [PdfFieldAttribute("FR_REMARKS-1")]
        [ChoCSVRecordField(22, FieldName = "REMARK1B")]
        public string FiscalHistRemarks1 { get; set; }

        [PdfFieldAttribute("EFFECTIVE_DATE-2")]
        [ChoCSVRecordField(23, FieldName = "EFFECTIVE DATE2")]
        public string EffectiveDate2 { get; set; }

        [PdfFieldAttribute("ACTION-2")]
        [ChoCSVRecordField(24, FieldName = "ACTION2")]
        public string Action2 { get; set; }

        [PdfFieldAttribute("BASE_PAY-2")]
        [ChoCSVRecordField(25, FieldName = "BASE PAY2")]
        public string BasePay2 { get; set; }

        [PdfFieldAttribute("SH_REMARKS-2")]
        [ChoCSVRecordField(26, FieldName = "REMARKS2A")]
        public string ServiceHistRemarks2 { get; set; }

        [PdfFieldAttribute("YEAR-2")]
        [ChoCSVRecordField(27, FieldName = "YEAR2")]
        public string Year2 { get; set; }

        [PdfFieldAttribute("CY_SALARY_DEDUCTIONS-2")]
        [ChoCSVRecordField(28, FieldName = "CY SAL DED2")]
        public string CYSalaryDeductions2 { get; set; }

        [PdfFieldAttribute("ACCUM_SAL_DEDUCTIONS-2")]
        [ChoCSVRecordField(29, FieldName = "ACC SAL DED2")]
        public string AccSalaryDeductions2 { get; set; }

        [PdfFieldAttribute("FR_REMARKS-2")]
        [ChoCSVRecordField(30, FieldName = "REMARK2B")]
        public string FiscalHistRemarks2 { get; set; }

        [PdfFieldAttribute("EFFECTIVE_DATE-3")]
        [ChoCSVRecordField(31, FieldName = "EFFECTIVE DATE3")]
        public string EffectiveDate3 { get; set; }

        [PdfFieldAttribute("ACTION-3")]
        [ChoCSVRecordField(32, FieldName = "ACTION3")]
        public string Action3 { get; set; }

        [PdfFieldAttribute("BASE_PAY-3")]
        [ChoCSVRecordField(33, FieldName = "BASE PAY3")]
        public string BasePay3 { get; set; }

        [PdfFieldAttribute("SH_REMARKS-3")]
        [ChoCSVRecordField(34, FieldName = "REMARKS3A")]
        public string ServiceHistRemarks3 { get; set; }

        [PdfFieldAttribute("YEAR-3")]
        [ChoCSVRecordField(35, FieldName = "YEAR3")]
        public string Year3 { get; set; }

        [PdfFieldAttribute("CY_SALARY_DEDUCTIONS-3")]
        [ChoCSVRecordField(36, FieldName = "CY SAL DED3")]
        public string CYSalaryDeductions3 { get; set; }

        [PdfFieldAttribute("ACCUM_SAL_DEDUCTIONS-3")]
        [ChoCSVRecordField(37, FieldName = "ACC SAL DED3")]
        public string AccSalaryDeductions3 { get; set; }

        [PdfFieldAttribute("FR_REMARKS-3")]
        [ChoCSVRecordField(38, FieldName = "REMARK3B")]
        public string FiscalHistRemarks3 { get; set; }

        [PdfFieldAttribute("EFFECTIVE_DATE-4")]
        [ChoCSVRecordField(39, FieldName = "EFFECTIVE DATE4")]
        public string EffectiveDate4 { get; set; }

        [PdfFieldAttribute("ACTION-4")]
        [ChoCSVRecordField(40, FieldName = "ACTION4")]
        public string Action4 { get; set; }

        [PdfFieldAttribute("BASE_PAY-4")]
        [ChoCSVRecordField(41, FieldName = "BASE PAY4")]
        public string BasePay4 { get; set; }

        [PdfFieldAttribute("SH_REMARKS-4")]
        [ChoCSVRecordField(42, FieldName = "REMARKS4A")]
        public string ServiceHistRemarks4 { get; set; }

        [PdfFieldAttribute("YEAR-4")]
        [ChoCSVRecordField(43, FieldName = "YEAR4")]
        public string Year4 { get; set; }

        [PdfFieldAttribute("CY_SALARY_DEDUCTIONS-4")]
        [ChoCSVRecordField(44, FieldName = "CY SAL DED4")]
        public string CYSalaryDeductions4 { get; set; }

        [PdfFieldAttribute("ACCUM_SAL_DEDUCTIONS-4")]
        [ChoCSVRecordField(45, FieldName = "ACC SAL DED4")]
        public string AccSalaryDeductions4 { get; set; }

        [PdfFieldAttribute("FR_REMARKS-4")]
        [ChoCSVRecordField(46, FieldName = "REMARK4B")]
        public string FiscalHistRemarks4 { get; set; }

        [PdfFieldAttribute("EFFECTIVE_DATE-5")]
        [ChoCSVRecordField(47, FieldName = "EFFECTIVE DATE5")]
        public string EffectiveDate5 { get; set; }

        [PdfFieldAttribute("ACTION-5")]
        [ChoCSVRecordField(48, FieldName = "ACTION5")]
        public string Action5 { get; set; }

        [PdfFieldAttribute("BASE_PAY-5")]
        [ChoCSVRecordField(49, FieldName = "BASE PAY5")]
        public string BasePay5 { get; set; }

        [PdfFieldAttribute("SH_REMARKS-5")]
        [ChoCSVRecordField(50, FieldName = "REMARKS5A")]
        public string ServiceHistRemarks5 { get; set; }

        [PdfFieldAttribute("YEAR-5")]
        [ChoCSVRecordField(51, FieldName = "YEAR5")]
        public string Year5 { get; set; }

        [PdfFieldAttribute("CY_SALARY_DEDUCTIONS-5")]
        [ChoCSVRecordField(52, FieldName = "CY SAL DED5")]
        public string CYSalaryDeductions5 { get; set; }

        [PdfFieldAttribute("ACCUM_SAL_DEDUCTIONS-5")]
        [ChoCSVRecordField(53, FieldName = "ACC SAL DED5")]
        public string AccSalaryDeductions5 { get; set; }

        [PdfFieldAttribute("FR_REMARKS-5")]
        [ChoCSVRecordField(54, FieldName = "REMARK5B")]
        public string FiscalHistRemarks5 { get; set; }

        [PdfFieldAttribute("EFFECTIVE_DATE-6")]
        [ChoCSVRecordField(55, FieldName = "EFFECTIVE DATE6")]
        public string EffectiveDate6 { get; set; }

        [PdfFieldAttribute("ACTION-6")]
        [ChoCSVRecordField(56, FieldName = "ACTION6")]
        public string Action6 { get; set; }

        [PdfFieldAttribute("BASE_PAY-6")]
        [ChoCSVRecordField(57, FieldName = "BASE PAY6")]
        public string BasePay6 { get; set; }

        [PdfFieldAttribute("SH_REMARKS-6]")]
        [ChoCSVRecordField(58, FieldName = "REMARKS6A")]
        public string ServiceHistRemarks6 { get; set; }

        [PdfFieldAttribute("YEAR-6")]
        [ChoCSVRecordField(59, FieldName = "YEAR6")]
        public string Year6 { get; set; }

        [PdfFieldAttribute("CY_SALARY_DEDUCTIONS-6")]
        [ChoCSVRecordField(60, FieldName = "CY SAL DED6")]
        public string CYSalaryDeductions6 { get; set; }

        [PdfFieldAttribute("ACCUM_SAL_DEDUCTIONS-6")]
        [ChoCSVRecordField(61, FieldName = "ACC SAL DED6")]
        public string AccSalaryDeductions6 { get; set; }

        [PdfFieldAttribute("FR_REMARKS-6")]
        [ChoCSVRecordField(62, FieldName = "REMARK6B")]
        public string FiscalHistRemarks6 { get; set; }

        [PdfFieldAttribute("EFFECTIVE_DATE-7")]
        [ChoCSVRecordField(63, FieldName = "EFFECTIVE DATE7")]
        public string EffectiveDate7 { get; set; }

        [PdfFieldAttribute("ACTION-7")]
        [ChoCSVRecordField(64, FieldName = "ACTION7")]
        public string Action7 { get; set; }

        [PdfFieldAttribute("BASE_PAY-7")]
        [ChoCSVRecordField(65, FieldName = "BASE PAY7")]
        public string BasePay7 { get; set; }

        [PdfFieldAttribute("SH_REMARKS-7")]
        [ChoCSVRecordField(66, FieldName = "REMARKS7A")]
        public string ServiceHistRemarks7 { get; set; }

        [PdfFieldAttribute("YEAR-7")]
        [ChoCSVRecordField(67, FieldName = "YEAR7")]
        public string Year7 { get; set; }

        [PdfFieldAttribute("CY_SALARY_DEDUCTIONS-7")]
        [ChoCSVRecordField(68, FieldName = "CY SAL DED7")]
        public string CYSalaryDeductions7 { get; set; }

        [PdfFieldAttribute("ACCUM_SAL_DEDUCTIONS-7")]
        [ChoCSVRecordField(69, FieldName = "ACC SAL DED7")]
        public string AccSalaryDeductions7 { get; set; }

        [PdfFieldAttribute("FR_REMARKS-7")]
        [ChoCSVRecordField(70, FieldName = "REMARK7B")]
        public string FiscalHistRemarks7 { get; set; }

        [PdfFieldAttribute("EFFECTIVE_DATE-8")]
        [ChoCSVRecordField(71, FieldName = "EFFECTIVE DATE8")]
        public string EffectiveDate8 { get; set; }

        [PdfFieldAttribute("ACTION-8")]
        [ChoCSVRecordField(72, FieldName = "ACTION8")]
        public string Action8 { get; set; }

        [PdfFieldAttribute("BASE_PAY-8")]
        [ChoCSVRecordField(73, FieldName = "BASE PAY8")]
        public string BasePay8 { get; set; }

        [PdfFieldAttribute("SH_REMARKS-8")]
        [ChoCSVRecordField(74, FieldName = "REMARKS8A")]
        public string ServiceHistRemarks8 { get; set; }

        [PdfFieldAttribute("YEAR-8")]
        [ChoCSVRecordField(75, FieldName = "YEAR8")]
        public string Year8 { get; set; }

        [PdfFieldAttribute("CY_SALARY_DEDUCTIONS-8")]
        [ChoCSVRecordField(76, FieldName = "CY SAL DED8")]
        public string CYSalaryDeductions8 { get; set; }

        [PdfFieldAttribute("ACCUM_SAL_DEDUCTIONS-8")]
        [ChoCSVRecordField(77, FieldName = "ACC SAL DED8")]
        public string AccSalaryDeductions8 { get; set; }

        [PdfFieldAttribute("FR_REMARKS-8")]
        [ChoCSVRecordField(78, FieldName = "REMARK8B")]
        public string FiscalHistRemarks8 { get; set; }

        [PdfFieldAttribute("EFFECTIVE_DATE-9")]
        [ChoCSVRecordField(79, FieldName = "EFFECTIVE DATE9")]
        public string EffectiveDate9 { get; set; }

        [PdfFieldAttribute("ACTION-9")]
        [ChoCSVRecordField(80, FieldName = "ACTION9")]
        public string Action9 { get; set; }

        [PdfFieldAttribute("BASE_PAY-9")]
        [ChoCSVRecordField(81, FieldName = "BASE PAY9")]
        public string BasePay9 { get; set; }

        [PdfFieldAttribute("SH_REMARKS-9")]
        [ChoCSVRecordField(82, FieldName = "REMARKS9A")]
        public string ServiceHistRemarks9 { get; set; }

        [PdfFieldAttribute("YEAR-9")]
        [ChoCSVRecordField(83, FieldName = "YEAR9")]
        public string Year9 { get; set; }

        [PdfFieldAttribute("CY_SALARY_DEDUCTIONS-9")]
        [ChoCSVRecordField(84, FieldName = "CY SAL DED9")]
        public string CYSalaryDeductions9 { get; set; }

        [PdfFieldAttribute("ACCUM_SAL_DEDUCTIONS-9")]
        [ChoCSVRecordField(85, FieldName = "ACC SAL DED9")]
        public string AccSalaryDeductions9 { get; set; }

        [PdfFieldAttribute("FR_REMARKS-9")]
        [ChoCSVRecordField(86, FieldName = "REMARK9B")]
        public string FiscalHistRemarks9 { get; set; }

        [PdfFieldAttribute("EFFECTIVE_DATE-10")]
        [ChoCSVRecordField(87, FieldName = "EFFECTIVE DATE10")]
        public string EffectiveDate10 { get; set; }

        [PdfFieldAttribute("ACTION-10")]
        [ChoCSVRecordField(88, FieldName = "ACTION10")]
        public string Action10 { get; set; }

        [PdfFieldAttribute("BASE_PAY-10")]
        [ChoCSVRecordField(89, FieldName = "BASE PAY10")]
        public string BasePay10 { get; set; }

        [PdfFieldAttribute("SH_REMARKS-10")]
        [ChoCSVRecordField(90, FieldName = "REMARKS10A")]
        public string ServiceHistRemarks10 { get; set; }

        [PdfFieldAttribute("YEAR-10")]
        [ChoCSVRecordField(91, FieldName = "YEAR10")]
        public string Year10 { get; set; }

        [PdfFieldAttribute("CY_SALARY_DEDUCTIONS-10")]
        [ChoCSVRecordField(92, FieldName = "CY SAL DED10")]
        public string CYSalaryDeductions10 { get; set; }

        [PdfFieldAttribute("ACCUM_SAL_DEDUCTIONS-10")]
        [ChoCSVRecordField(93, FieldName = "ACC SAL DED10")]
        public string AccSalaryDeductions10 { get; set; }

        [PdfFieldAttribute("FR_REMARKS-10")]
        [ChoCSVRecordField(94, FieldName = "REMARK10B")]
        public string FiscalHistRemarks10 { get; set; }

        [PdfFieldAttribute("EFFECTIVE_DATE-11")]
        [ChoCSVRecordField(95, FieldName = "EFFECTIVE DATE11")]
        public string EffectiveDate11 { get; set; }

        [PdfFieldAttribute("ACTION-11")]
        [ChoCSVRecordField(96, FieldName = "ACTION11")]
        public string Action11 { get; set; }

        [PdfFieldAttribute("BASE_PAY-11")]
        [ChoCSVRecordField(97, FieldName = "BASE PAY11")]
        public string BasePay11 { get; set; }

        [PdfFieldAttribute("SH_REMARKS-11")]
        [ChoCSVRecordField(98, FieldName = "REMARKS11A")]
        public string ServiceHistRemarks11 { get; set; }

        [PdfFieldAttribute("YEAR-11")]
        [ChoCSVRecordField(99, FieldName = "YEAR11")]
        public string Year11 { get; set; }

        [PdfFieldAttribute("CY_SALARY_DEDUCTIONS-11")]
        [ChoCSVRecordField(100, FieldName = "CY SAL DED11")]
        public string CYSalaryDeductions11 { get; set; }

        [PdfFieldAttribute("ACCUM_SAL_DEDUCTIONS-11")]
        [ChoCSVRecordField(101, FieldName = "ACC SAL DED11")]
        public string AccSalaryDeductions11 { get; set; }

        [PdfFieldAttribute("FR_REMARKS-11")]
        [ChoCSVRecordField(102, FieldName = "REMARK11B")]
        public string FiscalHistRemarks11 { get; set; }

        [PdfFieldAttribute("EFFECTIVE_DATE-12")]
        [ChoCSVRecordField(103, FieldName = "EFFECTIVE DATE12")]
        public string EffectiveDate12 { get; set; }

        [PdfFieldAttribute("ACTION-12")]
        [ChoCSVRecordField(104, FieldName = "ACTION12")]
        public string Action12 { get; set; }

        [PdfFieldAttribute("BASE_PAY-12")]
        [ChoCSVRecordField(105, FieldName = "BASE PAY12")]
        public string BasePay12 { get; set; }

        [PdfFieldAttribute("SH_REMARKS-12")]
        [ChoCSVRecordField(106, FieldName = "REMARKS12A")]
        public string ServiceHistRemarks12 { get; set; }

        [PdfFieldAttribute("YEAR-12")]
        [ChoCSVRecordField(107, FieldName = "YEAR12")]
        public string Year12 { get; set; }

        [PdfFieldAttribute("CY_SALARY_DEDUCTIONS-12")]
        [ChoCSVRecordField(108, FieldName = "CY SAL DED12")]
        public string CYSalaryDeductions12 { get; set; }

        [PdfFieldAttribute("ACCUM_SAL_DEDUCTIONS-12")]
        [ChoCSVRecordField(109, FieldName = "ACC SAL DED12")]
        public string AccSalaryDeductions12 { get; set; }

        [PdfFieldAttribute("FR_REMARKS-12")]
        [ChoCSVRecordField(110, FieldName = "REMARK12B")]
        public string FiscalHistRemarks12 { get; set; }

        [PdfFieldAttribute("EFFECTIVE_DATE-13")]
        [ChoCSVRecordField(111, FieldName = "EFFECTIVE DATE13")]
        public string EffectiveDate13 { get; set; }

        [PdfFieldAttribute("ACTION-13")]
        [ChoCSVRecordField(112, FieldName = "ACTION13")]
        public string Action13 { get; set; }

        [PdfFieldAttribute("BASE_PAY-13")]
        [ChoCSVRecordField(113, FieldName = "BASE PAY13")]
        public string BasePay13 { get; set; }

        [PdfFieldAttribute("SH_REMARKS-13")]
        [ChoCSVRecordField(114, FieldName = "REMARKS13A")]
        public string ServiceHistRemarks13 { get; set; }

        [PdfFieldAttribute("YEAR-13")]
        [ChoCSVRecordField(115, FieldName = "YEAR13")]
        public string Year13 { get; set; }

        [PdfFieldAttribute("CY_SALARY_DEDUCTIONS-13")]
        [ChoCSVRecordField(116, FieldName = "CY SAL DED13")]
        public string CYSalaryDeductions13 { get; set; }

        [PdfFieldAttribute("ACCUM_SAL_DEDUCTIONS-13")]
        [ChoCSVRecordField(117, FieldName = "ACC SAL DED13")]
        public string AccSalaryDeductions13 { get; set; }

        [PdfFieldAttribute("FR_REMARKS-13")]
        [ChoCSVRecordField(118, FieldName = "REMARK13B")]
        public string FiscalHistRemarks13 { get; set; }

        [PdfFieldAttribute("EFFECTIVE_DATE-14")]
        [ChoCSVRecordField(119, FieldName = "EFFECTIVE DATE14")]
        public string EffectiveDate14 { get; set; }

        [PdfFieldAttribute("ACTION-14")]
        [ChoCSVRecordField(120, FieldName = "ACTION14")]
        public string Action14 { get; set; }

        [PdfFieldAttribute("BASE_PAY-14")]
        [ChoCSVRecordField(121, FieldName = "BASE PAY14")]
        public string BasePay14 { get; set; }

        [PdfFieldAttribute("SH_REMARKS-14")]
        [ChoCSVRecordField(122, FieldName = "REMARKS14A")]
        public string ServiceHistRemarks14 { get; set; }

        [PdfFieldAttribute("YEAR-14")]
        [ChoCSVRecordField(123, FieldName = "YEAR14")]
        public string Year14 { get; set; }

        [PdfFieldAttribute("CY_SALARY_DEDUCTIONS-14")]
        [ChoCSVRecordField(124, FieldName = "CY SAL DED14")]
        public string CYSalaryDeductions14 { get; set; }

        [PdfFieldAttribute("ACCUM_SAL_DEDUCTIONS-14")]
        [ChoCSVRecordField(125, FieldName = "ACC SAL DED14")]
        public string AccSalaryDeductions14 { get; set; }

        [PdfFieldAttribute("FR_REMARKS-14")]
        [ChoCSVRecordField(126, FieldName = "REMARK14B")]
        public string FiscalHistRemarks14 { get; set; }

        [PdfFieldAttribute("EFFECTIVE_DATE-15")]
        [ChoCSVRecordField(127, FieldName = "EFFECTIVE DATE15")]
        public string EffectiveDate15 { get; set; }

        [PdfFieldAttribute("ACTION-15")]
        [ChoCSVRecordField(128, FieldName = "ACTION15")]
        public string Action15 { get; set; }

        [PdfFieldAttribute("BASE_PAY-15")]
        [ChoCSVRecordField(129, FieldName = "BASE PAY15")]
        public string BasePay15 { get; set; }

        [PdfFieldAttribute("SH_REMARKS-15")]
        [ChoCSVRecordField(130, FieldName = "REMARKS15A")]
        public string ServiceHistRemarks15 { get; set; }

        [PdfFieldAttribute("YEAR-15")]
        [ChoCSVRecordField(131, FieldName = "YEAR15")]
        public string Year15 { get; set; }

        [PdfFieldAttribute("CY_SALARY_DEDUCTIONS-15")]
        [ChoCSVRecordField(132, FieldName = "CY SAL DED15")]
        public string CYSalaryDeductions15 { get; set; }

        [PdfFieldAttribute("ACCUM_SAL_DEDUCTIONS-15")]
        [ChoCSVRecordField(133, FieldName = "ACC SAL DED15")]
        public string AccSalaryDeductions15 { get; set; }

        [PdfFieldAttribute("FH_REMARKS-15")]
        [ChoCSVRecordField(134, FieldName = "REMARK15B")]
        public string FiscalHistRemarks15 { get; set; }

        [PdfFieldAttribute("EFFECTIVE_DATE-16")]
        [ChoCSVRecordField(135, FieldName = "EFFECTIVE DATE16")]
        public string EffectiveDate16 { get; set; }

        [PdfFieldAttribute("ACTION-16")]
        [ChoCSVRecordField(136, FieldName = "ACTION16")]
        public string Action16 { get; set; }

        [PdfFieldAttribute("BASE_PAY-16")]
        [ChoCSVRecordField(137, FieldName = "BASE PAY16")]
        public string BasePay16 { get; set; }

        [PdfFieldAttribute("SH_REMARKS-16")]
        [ChoCSVRecordField(138, FieldName = "REMARKS16A")]
        public string ServiceHistRemarks16 { get; set; }

        [PdfFieldAttribute("YEAR-16")]
        [ChoCSVRecordField(139, FieldName = "YEAR16")]
        public string Year16 { get; set; }

        [PdfFieldAttribute("CY_SALARY_DEDUCTIONS-16")]
        [ChoCSVRecordField(140, FieldName = "CY SAL DED16")]
        public string CYSalaryDeductions16 { get; set; }

        [PdfFieldAttribute("ACCUM_SAL_DEDUCTIONS-16")]
        [ChoCSVRecordField(141, FieldName = "ACC SAL DED16")]
        public string AccSalaryDeductions16 { get; set; }

        [PdfFieldAttribute("FR_REMARKS-16")]
        [ChoCSVRecordField(142, FieldName = "REMARK16B")]
        public string FiscalHistRemarks16 { get; set; }

        [PdfFieldAttribute("EFFECTIVE_DATE-17")]
        [ChoCSVRecordField(143, FieldName = "EFFECTIVE DATE17")]
        public string EffectiveDate17 { get; set; }

        [PdfFieldAttribute("ACTION-17")]
        [ChoCSVRecordField(144, FieldName = "ACTION17")]
        public string Action17 { get; set; }

        [PdfFieldAttribute("BASE_PAY-17")]
        [ChoCSVRecordField(145, FieldName = "BASE PAY17")]
        public string BasePay17 { get; set; }

        [PdfFieldAttribute("SH_REMARKS-17")]
        [ChoCSVRecordField(146, FieldName = "REMARKS17A")]
        public string ServiceHistRemarks17 { get; set; }

        [PdfFieldAttribute("YEAR-17")]
        [ChoCSVRecordField(147, FieldName = "YEAR17")]
        public string Year17 { get; set; }

        [PdfFieldAttribute("CY_SALARY_DEDUCTIONS-17")]
        [ChoCSVRecordField(148, FieldName = "CY SAL DED17")]
        public string CYSalaryDeductions17 { get; set; }

        [PdfFieldAttribute("ACCUM_SAL_DEDUCTIONS-17")]
        [ChoCSVRecordField(149, FieldName = "ACC SAL DED17")]
        public string AccSalaryDeductions17 { get; set; }

        [PdfFieldAttribute("FR_REMARKS-17")]
        [ChoCSVRecordField(150, FieldName = "REMARK17B")]
        public string FiscalHistRemarks17 { get; set; }

        [PdfFieldAttribute("EFFECTIVE_DATE-18")]
        [ChoCSVRecordField(151, FieldName = "EFFECTIVE DATE18")]
        public string EffectiveDate18 { get; set; }

        [PdfFieldAttribute("ACTION-18")]
        [ChoCSVRecordField(152, FieldName = "ACTION18")]
        public string Action18 { get; set; }

        [PdfFieldAttribute("BASE_PAY-18")]
        [ChoCSVRecordField(153, FieldName = "BASE PAY18")]
        public string BasePay18 { get; set; }

        [PdfFieldAttribute("SH_REMARKS-18")]
        [ChoCSVRecordField(154, FieldName = "REMARKS18A")]
        public string ServiceHistRemarks18 { get; set; }

        [PdfFieldAttribute("YEAR-18")]
        [ChoCSVRecordField(155, FieldName = "YEAR18")]
        public string Year18 { get; set; }

        [PdfFieldAttribute("CY_SALARY_DEDUCTIONS-18")]
        [ChoCSVRecordField(156, FieldName = "CY SAL DED18")]
        public string CYSalaryDeductions18 { get; set; }

        [PdfFieldAttribute("ACCUM_SAL_DEDUCTIONS-18")]
        [ChoCSVRecordField(157, FieldName = "ACC SAL DED18")]
        public string AccSalaryDeductions18 { get; set; }


        [PdfFieldAttribute("FR_REMARKS-18")]
        [ChoCSVRecordField(158, FieldName = "REMARK18B")]
        public string FiscalHistRemarks18 { get; set; }

        [PdfFieldAttribute("EFFECTIVE_DATE-19")]
        [ChoCSVRecordField(159, FieldName = "EFFECTIVE DATE19")]
        public string EffectiveDate19 { get; set; }

        [PdfFieldAttribute("ACTION-19")]
        [ChoCSVRecordField(160, FieldName = "ACTION19")]
        public string Action19 { get; set; }

        [PdfFieldAttribute("BASE_PAY-19")]
        [ChoCSVRecordField(161, FieldName = "BASE PAY19")]
        public string BasePay19 { get; set; }

        [PdfFieldAttribute("SH_REMARKS-19")]
        [ChoCSVRecordField(162, FieldName = "REMARKS19A")]
        public string ServiceHistRemarks19 { get; set; }

        [PdfFieldAttribute("YEAR-19")]
        [ChoCSVRecordField(163, FieldName = "YEAR19")]
        public string Year19 { get; set; }

        [PdfFieldAttribute("CY_SALARY_DEDUCTIONS-19")]
        [ChoCSVRecordField(164, FieldName = "CY SAL DED19")]
        public string CYSalaryDeductions19 { get; set; }

        [PdfFieldAttribute("ACCUM_SAL_DEDUCTIONS-19")]
        [ChoCSVRecordField(165, FieldName = "ACC SAL DED19")]
        public string AccSalaryDeductions19 { get; set; }

        [PdfFieldAttribute("FR_REMARKS-19")]
        [ChoCSVRecordField(166, FieldName = "REMARK19B")]
        public string FiscalHistRemarks19 { get; set; }

        [PdfFieldAttribute("EFFECTIVE_DATE-20")]
        [ChoCSVRecordField(167, FieldName = "EFFECTIVE DATE20")]
        public string EffectiveDate20 { get; set; }

        [PdfFieldAttribute("ACTION-20")]
        [ChoCSVRecordField(168, FieldName = "ACTION20")]
        public string Action20 { get; set; }

        [PdfFieldAttribute("BASE_PAY-20")]
        [ChoCSVRecordField(169, FieldName = "BASE PAY20")]
        public string BasePay20 { get; set; }

        [PdfFieldAttribute("SH_REMARKS-20")]
        [ChoCSVRecordField(170, FieldName = "REMARKS20A")]
        public string ServiceHistRemarks20 { get; set; }

        [PdfFieldAttribute("YEAR-20")]
        [ChoCSVRecordField(171, FieldName = "YEAR20")]
        public string Year20 { get; set; }

        [PdfFieldAttribute("CY_SALARY_DEDUCTIONS-20")]
        [ChoCSVRecordField(172, FieldName = "CY SAL DED20")]
        public string CYSalaryDeductions20 { get; set; }

        [PdfFieldAttribute("ACCUM_SAL_DEDUCTIONS-20")]
        [ChoCSVRecordField(173, FieldName = "ACC SAL DED20")]
        public string AccSalaryDeductions20 { get; set; }

        [PdfFieldAttribute("FR_REMARKS-20")]
        [ChoCSVRecordField(174, FieldName = "REMARK20B")]
        public string FiscalHistRemarks20 { get; set; }

        [PdfFieldAttribute("EFFECTIVE_DATE-21")]
        [ChoCSVRecordField(175, FieldName = "EFFECTIVE DATE21")]
        public string EffectiveDate21 { get; set; }

        [PdfFieldAttribute("ACTION-21")]
        [ChoCSVRecordField(176, FieldName = "ACTION21")]
        public string Action21 { get; set; }

        [PdfFieldAttribute("BASE_PAY-21")]
        [ChoCSVRecordField(177, FieldName = "BASE PAY21")]
        public string BasePay21 { get; set; }

        [PdfFieldAttribute("SH_REMARKS-21")]
        [ChoCSVRecordField(178, FieldName = "REMARKS21A")]
        public string ServiceHistRemarks21 { get; set; }

        [PdfFieldAttribute("YEAR-21")]
        [ChoCSVRecordField(179, FieldName = "YEAR21")]
        public string Year21 { get; set; }

        [PdfFieldAttribute("CY_SALARY_DEDUCTIONS-21")]
        [ChoCSVRecordField(180, FieldName = "CY SAL DED21")]
        public string CYSalaryDeductions21 { get; set; }

        [PdfFieldAttribute("ACCUM_SAL_DEDUCTIONS-21")]
        [ChoCSVRecordField(181, FieldName = "ACC SAL DED21")]
        public string AccSalaryDeductions21 { get; set; }

        [PdfFieldAttribute("FR_REMARKS-21")]
        [ChoCSVRecordField(182, FieldName = "REMARK21B")]
        public string FiscalHistRemarks21 { get; set; }

        [PdfFieldAttribute("EFFECTIVE_DATE-22")]
        [ChoCSVRecordField(183, FieldName = "EFFECTIVE DATE22")]
        public string EffectiveDate22 { get; set; }

        [PdfFieldAttribute("ACTION-22")]
        [ChoCSVRecordField(184, FieldName = "ACTION22")]
        public string Action22 { get; set; }

        [PdfFieldAttribute("BASE_PAY-22")]
        [ChoCSVRecordField(185, FieldName = "BASE PAY22")]
        public string BasePay22 { get; set; }

        [PdfFieldAttribute("SH_REMARKS-22")]
        [ChoCSVRecordField(186, FieldName = "REMARKS22A")]
        public string ServiceHistRemarks22 { get; set; }

        [PdfFieldAttribute("YEAR-22")]
        [ChoCSVRecordField(187, FieldName = "YEAR22")]
        public string Year22 { get; set; }

        [PdfFieldAttribute("CY_SALARY_DEDUCTIONS-22")]
        [ChoCSVRecordField(188, FieldName = "CY SAL DED22")]
        public string CYSalaryDeductions22 { get; set; }

        [PdfFieldAttribute("ACCUM_SAL_DEDUCTIONS-22")]
        [ChoCSVRecordField(189, FieldName = "ACC SAL DED22")]
        public string AccSalaryDeductions22 { get; set; }

        [PdfFieldAttribute("FR_REMARKS-22")]
        [ChoCSVRecordField(190, FieldName = "REMARK22B")]
        public string FiscalHistRemarks22 { get; set; }

        [PdfFieldAttribute("EFFECTIVE_DATE-23")]
        [ChoCSVRecordField(191, FieldName = "EFFECTIVE DATE23")]
        public string EffectiveDate23 { get; set; }

        [PdfFieldAttribute("ACTION-23")]
        [ChoCSVRecordField(192, FieldName = "ACTION23")]
        public string Action23 { get; set; }

        [PdfFieldAttribute("BASE_PAY-23")]
        [ChoCSVRecordField(193, FieldName = "BASE PAY23")]
        public string BasePay23 { get; set; }

        [PdfFieldAttribute("SH_REMARKS-23")]
        [ChoCSVRecordField(194, FieldName = "REMARKS23A")]
        public string ServiceHistRemarks23 { get; set; }

        [PdfFieldAttribute("YEAR-23")]
        [ChoCSVRecordField(195, FieldName = "YEAR23")]
        public string Year23 { get; set; }

        [PdfFieldAttribute("CY_SALARY_DEDUCTIONS-23")]
        [ChoCSVRecordField(196, FieldName = "CY SAL DED23")]
        public string CYSalaryDeductions23 { get; set; }

        [PdfFieldAttribute("ACCUM_SAL_DEDUCTIONS-23")]
        [ChoCSVRecordField(197, FieldName = "ACC SAL DED23")]
        public string AccSalaryDeductions23 { get; set; }

        [PdfFieldAttribute("FR-REMARKS-23")]
        [ChoCSVRecordField(198, FieldName = "REMARK23B")]
        public string FiscalHistRemarks23 { get; set; }

        [PdfFieldAttribute("EFFECTIVE_DATE-24")]
        [ChoCSVRecordField(199, FieldName = "EFFECTIVE DATE24")]
        public string EffectiveDate24 { get; set; }

        [PdfFieldAttribute("ACTION-24")]
        [ChoCSVRecordField(200, FieldName = "ACTION24")]
        public string Action24 { get; set; }

        [PdfFieldAttribute("BASE_PAY-24")]
        [ChoCSVRecordField(201, FieldName = "BASE PAY24")]
        public string BasePay24 { get; set; }

        [PdfFieldAttribute("SH_REMARKS-24")]
        [ChoCSVRecordField(202, FieldName = "REMARKS24A")]
        public string ServiceHistRemarks24 { get; set; }

        [PdfFieldAttribute("YEAR-24")]
        [ChoCSVRecordField(203, FieldName = "YEAR24")]
        public string Year24 { get; set; }

        [PdfFieldAttribute("CY_SALARY_DEDUCTIONS-24")]
        [ChoCSVRecordField(204, FieldName = "CY SAL DED24")]
        public string CYSalaryDeductions24 { get; set; }

        [PdfFieldAttribute("ACCUM_SAL_DEDUCTIONS-24")]
        [ChoCSVRecordField(205, FieldName = "ACC SAL DED24")]
        public string AccSalaryDeductions24 { get; set; }

        [PdfFieldAttribute("FR_REMARKS-24")]
        [ChoCSVRecordField(206, FieldName = "REMARK24B")]
        public string FiscalHistRemarks24 { get; set; }

        [PdfFieldAttribute("EFFECTIVE_DATE-25")]
        [ChoCSVRecordField(207, FieldName = "EFFECTIVE DATE25")]
        public string EffectiveDate25 { get; set; }

        [PdfFieldAttribute("ACTION-25")]
        [ChoCSVRecordField(208, FieldName = "ACTION25")]
        public string Action25 { get; set; }

        [PdfFieldAttribute("BASE_PAY-25")]
        [ChoCSVRecordField(209, FieldName = "BASE PAY25")]
        public string BasePay25 { get; set; }

        [PdfFieldAttribute("SH_REMARKS-25")]
        [ChoCSVRecordField(210, FieldName = "REMARKS25A")]
        public string ServiceHistRemarks25 { get; set; }

        [PdfFieldAttribute("YEAR-25")]
        [ChoCSVRecordField(211, FieldName = "YEAR25")]
        public string Year25 { get; set; }

        [PdfFieldAttribute("CY_SALARY_DEDUCTIONS-25")]
        [ChoCSVRecordField(212, FieldName = "CY SAL DED25")]
        public string CYSalaryDeductions25 { get; set; }

        [PdfFieldAttribute("ACCUM_SAL_DEDUCTIONS-25")]
        [ChoCSVRecordField(213, FieldName = "ACC SAL DED25")]
        public string AccSalaryDeductions25 { get; set; }

        [PdfFieldAttribute("FR_REMARKS-25")]
        [ChoCSVRecordField(214, FieldName = "REMARK25B")]
        public string FiscalHistRemarks25 { get; set; }

        [PdfFieldAttribute("BOTTOM_BOX")]
        [ChoCSVRecordField(231, FieldName = "SEPNUM")]
        public string SepNumbers { get; set; }
    }
}