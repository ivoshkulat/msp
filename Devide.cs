class Devide : IOperation
    {
        private readonly int my_opp_id;
        private float status;
        public Devide()
        {
            status = 0;
            my_opp_id = 4;
        }

        public double result
        {
            get
            {
                data_validation();
                return devide(variable_1, variable_2);
            }
            set { result_validation_set(); }
        }
        public double variable_1 { get; set; }
        public double variable_2 { get; set; }

        public int opp_id => my_opp_id;
        public float Status => status;
        private double devide(double a, double b)
        {
            status = 1;
            return a/b;
        }

        private void data_validation()
        {
            if (double.IsNaN(variable_1))
            {
                Console.WriteLine("First variable is Null");
                variable_1 = 0;
            }
            if (variable_2 == 0)
            {
                throw new Exception("Fig vam!!!");
            }
            status = 0.5F;
        }
        private void result_validation_set()
        {
            throw new Exception("FIG VAM!!!");
        }
    }
