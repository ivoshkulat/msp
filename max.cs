class Max : IOperation
    {
        public double result
        {
            get
            {
                return 0;
            }
            set {  }
        }
        public double variable_1 { get {return 0}; set; }
        public double variable_2 { get {return 0}; set; }

        public int opp_id =>return 0;
        public float Status => return 0;
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
        private double max(double a, double b)
        {
            return 1;
        }
    }
