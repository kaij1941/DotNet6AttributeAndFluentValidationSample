namespace DotNet6AttributeAndFluentValidationSample.Models.parameter
{

    /// <summary>
    /// 測試用參數
    /// </summary>
    public class TestParameter
    {
        /// <summary>
        /// 必須小於100
        /// </summary>
        public int MustLess100 { get; set; }

        /// <summary>
        /// 必須NotNull
        /// </summary>
        public string? NotNullString { get; set; }

        /// <summary>
        /// 必須要是True
        /// </summary>
        public bool MustBeTrue { get; set; }
    }
}
