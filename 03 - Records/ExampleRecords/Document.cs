namespace Records.ExampleRecords
{
    record Document
    {
        public string Number { get; set; }
    }

    record DriverLicense : Document
    {
        public string Categories { get; set; }
    }
}
