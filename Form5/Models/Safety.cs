using System;
using System.Collections.Generic;

namespace Form5.Models;

public partial class Safety
{
    public int Id { get; set; }

    public string? Plant { get; set; }

    public string? Department { get; set; }

    public string? NameofSupervisor { get; set; }

    public string? TypesofIncident { get; set; }


    public string? NameofInjuredPerson { get; set; }

    public string? Gender { get; set; }

    public string? BloodGroup { get; set; }

    public string? InjuriLevel { get; set; }

    public string? InjuriDescription { get; set; }

    public string? EquipmentDamage { get; set; }

    public string? EquipmentDescription { get; set; }

    public string? Rca { get; set; }

    public string? Reason { get; set; }

    public string? Capa { get; set; }

    public byte[]? Photo { get; set; }
    public string ImageUrl { get; set; } = string.Empty;

    public List<string> Options = new List<string> { "Male", "Female" };

    public List<Item> items = new List<Item>
    {
        new Item { Id = 1, Name = "Personal Injuri", IsSelected = false },
        new Item { Id = 2, Name = "Equipment Damage", IsSelected = false }

    };

}

public class Item
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsSelected { get; set; }
}

