class Max : IOperation
    {
        private readonly int my_opp_id;
        private float status;
        public Max()
        {
            status = 0;
            my_opp_id = 9;
        }

        public double result
        {
            get
            {
                data_validation();
                return max(variable_1, variable_2);
            }
            set { result_validation_set(); }
        }
        public double variable_1 { get; set; }
        public double variable_2 { get; set; }

        public int opp_id => my_opp_id;
        public float Status => status;
        private double max(double a, double b)
        {
            status = 1;
            return (a > b) ? a : b;
        }

        private void data_validation()
        {
            if (double.IsNaN(variable_1))
            {
                Console.WriteLine("First variable is Null");
                variable_1 = 0;
            }
            if (double.IsNaN(variable_2))
            {
                Console.WriteLine("Second variable is Null");
                variable_1 = 0;
            }
            status = 0.5F;
        }
        private void result_validation_set()
        {
            throw new Exception("FIG VAM!!!");
        }
    }
