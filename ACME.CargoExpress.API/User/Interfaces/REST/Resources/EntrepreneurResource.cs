﻿namespace ACME.CargoExpress.API.User.Interfaces.REST.Resources;

public record EntrepreneurResource(int Id, string Name, string Phone, string Ruc, string Address, int UserId, string LogoImage);