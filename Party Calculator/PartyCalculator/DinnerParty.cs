﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayParty__first_version_
{
    public class DinnerParty : Party
    {
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
            : base(numberOfPeople, fancyDecorations)
        {
            HealthyOption = healthyOption;
        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            return HealthyOption ? 5.00M : 20.00M;
        }

        public override decimal Cost
        {
            get
            {
                decimal beveragesCost = CalculateCostOfBeveragesPerPerson() * NumberOfPeople;
                decimal totalCost = base.Cost + beveragesCost;
                totalCost *= (HealthyOption ? 0.95M : 1.0M);

                return totalCost;
            }
        }
    }
}