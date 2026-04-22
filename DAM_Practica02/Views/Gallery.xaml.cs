using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace DAM_Practica02.Views;

public partial class Gallery : ContentPage
{
	public Gallery()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Creates an instance of type Animal holding all Griffon Vulture data. Creates an instance of Details Page and pushes the animal instance via BindingContext.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
	public async void OnGriffonVultureClicked(object sender, EventArgs e)
	{
		var animal = new Animal
		{
			Name = "Griffon Vulture",
			ScientificName = "Gyps fulvus",
            ImageReference = "buitre_leonado.jpg",
			Description = "From the time the ancient inhabitants of the Iberian Peninsula became herders until the present day, the griffon vulture has been closely linked to human pastoral activities, performing an effective—though sometimes misunderstood—sanitation role. Stupidly persecuted for decades, this scavenger entered a dangerous decline from which, once the pressure eased, it recovered spectacularly, to the point that, on occasion, several autonomous communities have participated in plans to reintroduce the species in different countries by donating individuals."
        };

		await Navigation.PushAsync(new Details { BindingContext = animal });
	}

    /// <summary>
    /// Creates an instance of type Animal holding all Chimpanzee data. Creates an instance of Details Page and pushes the animal instance via BindingContext.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public async void OnChimpanzeeClicked(object sender, EventArgs e)
	{
		var animal = new Animal
		{
			Name = "Chimpanzee",
			ScientificName = "Pan troglodytes",
            ImageReference = "chimpance.jpg",
            Description = "Chimpanzees are highly social, diurnal primates.They move around primarily on all fours and spend a lot of time resting in trees and eating fruit.They forage mainly during the day and at dusk; the rest of the time is spent resting and strengthening social bonds."
        };
        await Navigation.PushAsync(new Details { BindingContext = animal });
    }


    /// <summary>
    /// Creates an instance of type Animal holding all African Elephant data. Creates an instance of Details Page and pushes the animal instance via BindingContext.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public async void OnAfricanElephantClicked(object sender, EventArgs e)
	{
		var animal = new Animal
		{
			Name = "African elephant",
			ScientificName = "Loxodonta africana",
            ImageReference = "elephant.jpg",
            Description = "Elephants are social creatures. They sometimes hug by wrapping their trunks together in displays of greeting and affection. Elephants also use their trunks to help lift or nudge an elephant calf over an obstacle, to rescue a fellow elephant stuck in mud, or to gently raise a newborn elephant to its feet. And just as a human baby sucks its thumb, an elephant calf often sucks its trunk for comfort. One elephant can eat 300 pounds (136 kilograms) of food in one day."
        };
        await Navigation.PushAsync(new Details { BindingContext = animal });
    }

    /// <summary>
    /// Creates an instance of type Animal holding all Lion data. Creates an instance of Details Page and pushes the animal instance via BindingContext.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public async void OnLionClicked(object sender, EventArgs e)
    {
        var animal = new Animal
        {
            Name = "Lion",
            ScientificName = "Panthera leo",
            ImageReference = "lion.jpg",
            Description = "Lions are the most social of all cats. They are the only cats that live in large family groups called “prides,” consisting of four to 12 adult females related to their offspring, plus two or three unrelated adult males. Lions also hunt in groups using stalking and ambush techniques. The females do most of the hunting. All members of the pride share the kill, with the males eating first, followed by the females, and then the cubs. The males protect the females and cubs from other lions and hyenas."
        };
        await Navigation.PushAsync(new Details { BindingContext = animal });
    }


    /// <summary>
    /// Creates an instance of type Animal holding all Zebra data. Creates an instance of Details Page and pushes the animal instance via BindingContext.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public async void OnZebraClicked(object sender, EventArgs e)
    {
        var animal = new Animal
        {
            Name = "Zebra",
            ScientificName = "Equus quagga",
            ImageReference = "zebra.jpg",
            Description = "No animal in the world has a coat as distinctive as that of the zebra. The stripes on each individual are as unique as human fingerprints. No two are exactly alike, and furthermore, the coat of each of the three distinct species of zebra follows a different color pattern. \nWhy do zebras have stripes? Scientists aren’t sure, but many theories focus on their usefulness as a form of camouflage. "
        };
        await Navigation.PushAsync(new Details { BindingContext = animal });
    }
}

/// <summary>
/// Stores data for Details page related to an animal
/// </summary>
public class Animal
{
    public string Name { get; set; }
	public string ScientificName { get; set; }
	public string ImageReference { get; set; }
	public string Description { get; set; }
}