﻿using Domain.Enums;

namespace Domain.Entities;

public class Price
{
    public double Amount { get; set; }
    public Currency Currency { get; set; }
}

