namespace InitOnlySetters.ExampleClasses
{
    class Receipt 
    {
        public decimal TransactionValue { get; set; }

        public Receipt(decimal transactionValue)
        {
            this.TransactionValue = transactionValue;
        }

        public void ProcessReceipt()
        {
            //// Private set ===> 
            //// Init ==========> 
            this.TransactionValue = this.TransactionValue / 2;
        }
    }
}
