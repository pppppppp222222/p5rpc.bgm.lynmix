using System.ComponentModel;
using p5rpc.bgm.lynmix.Template.Configuration;
using Reloaded.Mod.Interfaces.Structs;

namespace p5rpc.bgm.lynmix.Configuration;

public class Config : Configurable<Config>
{
    /*
        User Properties:
            - Please put all of your configurable properties here.
    
        By default, configuration saves as "Config.json" in mod user config folder.    
        Need more config files/classes? See Configuration.cs
    
        Available Attributes:
        - Category
        - DisplayName
        - Description
        - DefaultValue

        // Technically Supported but not Useful
        - Browsable
        - Localizable

        The `DefaultValue` attribute is used as part of the `Reset` button in Reloaded-Launcher.
    */

/// AMBUSH

    [DisplayName("Axe to Grind")]
    [Category("Ambush")]
    [Description("\"Axe to Grind\" from P5S")]
    [DefaultValue(true)]
    public bool a_Axe_to_Grind { get; set; } = true;

    [DisplayName("Counter Strike")]
    [Category("Ambush")]
    [Description("\"Counter Strike\" from P5S")]
    [DefaultValue(true)]
    public bool a_Counter_Strike { get; set; } = true;

    [DisplayName("Daredevil")]
    [Category("Ambush")]
    [Description("\"Daredevil\" from P5S")]
    [DefaultValue(true)]
    public bool a_Daredevil { get; set; } = true;

    [DisplayName("Fatal Desire")]
    [Category("Ambush")]
    [Description("\"Fatal Desire\" from P5X")]
    [DefaultValue(true)]
    public bool a_Fatal_Desire { get; set; } = true;

    [DisplayName("Got Your Tail")]
    [Category("Ambush")]
    [Description("\"Got Your Tail\" from P5T")]
    [DefaultValue(false)]
    public bool a_Got_Your_Tail { get; set; } = false;

    [DisplayName("Inextinguishable")]
    [Category("Ambush")]
    [Description("\"Inextinguishable\" from P5T")]
    [DefaultValue(false)]
    public bool a_Inextinguishable { get; set; } = false;
    
    [DisplayName("Invitation to Freedom")]
    [Category("Ambush")]
    [Description("\"Invitation to Freedom\" from PQ2")]
    [DefaultValue(true)]
    public bool a_Invitation_to_Freedom { get; set; } = true;
    
    [DisplayName("It's Too Late")]
    [Category("Ambush")]
    [Description("\"It's Too Late\" from P5A")]
    [DefaultValue(false)]
    public bool a_Its_Too_Late { get; set; } = false;
    
    [DisplayName("Last Strike")]
    [Category("Ambush")]
    [Description("\"Last Strike\" from P5X")]
    [DefaultValue(true)]
    public bool a_Last_Strike { get; set; } = true;

    [DisplayName("Last Surprise")]
    [Category("Ambush")]
    [Description("\"Last Surprise\" from P5")]
    [DefaultValue(false)]
    public bool a_Last_Surprise { get; set; } = false;

    [DisplayName("Last Surprise -Scramble-")]
    [Category("Ambush")]
    [Description("\"Last Surprise -Scramble-\" from P5S")]
    [DefaultValue(false)]
    public bool a_Last_SurpriseS { get; set; } = false;

    [DisplayName("Revolution in Your Heart")]
    [Category("Ambush")]
    [Description("\"Revolution in Your Heart\" from P5T")]
    [DefaultValue(false)]
    public bool a_Revolution_in_your_Heart { get; set; } = false;

    [DisplayName("Revolution is a Blade")]
    [Category("Ambush")]
    [Description("\"Revolution is a Blade\" from P5T")]
    [DefaultValue(false)]
    public bool a_Revolution_is_a_Blade { get; set; } = false;

    [DisplayName("Shadow Loop")]
    [Category("Ambush")]
    [Description("\"Shadow Loop\" from P5X")]
    [DefaultValue(true)]
    public bool a_Shadow_Loop { get; set; } = true;

    [DisplayName("Take Over")]
    [Category("Ambush")]
    [Description("\"Take Over\" from P5R")]
    [DefaultValue(true)]
    public bool a_Take_Over { get; set; } = true;

    [DisplayName("The Night We Stood")]
    [Category("Ambush")]
    [Description("\"The Night We Stood\" from P5T")]
    [DefaultValue(false)]
    public bool a_The_Night_We_Stood { get; set; } = false;

    [DisplayName("Truth or Dare")]
    [Category("Ambush")]
    [Description("\"Truth or Dare\" from P5T")]
    [DefaultValue(false)]
    public bool a_Truth_or_Dare { get; set; } = false;

    [DisplayName("Wake Up Your Hero")]
    [Category("Ambush")]
    [Description("\"Wake Up Your Hero\" from P5X")]
    [DefaultValue(true)]
    public bool a_Wake_Up_Your_Hero { get; set; } = true;

    [DisplayName("What You Wish For")]
    [Category("Ambush")]
    [Description("\"What You Wish For\" from P5S")]
    [DefaultValue(true)]
    public bool a_What_You_Wish_For { get; set; } = true;

    [DisplayName("You Are Stronger")]
    [Category("Ambush")]
    [Description("\"You Are Stronger\" from P5S")]
    [DefaultValue(true)]
    public bool a_You_Are_Stronger { get; set; } = true;

    [DisplayName("[Non-Vocal] Desire Surrender")]
    [Category("Ambush")]
    [Description("\"Desire Surrender\" from P5X")]
    [DefaultValue(false)]
    public bool a_Desire_Surrender { get; set; } = false;

    [DisplayName("[Non-Vocal] Prison Labor")]
    [Category("Ambush")]
    [Description("\"Prison Labor\" from P5R")]
    [DefaultValue(false)]
    public bool a_Prison_Labor { get; set; } = false;

/// DISADVANTAGE

    [DisplayName("Axe to Grind")]
    [Category("Disadvantage")]
    [Description("\"Axe to Grind\" from P5S")]
    [DefaultValue(false)]
    public bool d_Axe_to_Grind { get; set; } = false;

    [DisplayName("Counter Strike")]
    [Category("Disadvantage")]
    [Description("\"Counter Strike\" from P5S")]
    [DefaultValue(false)]
    public bool d_Counter_Strike { get; set; } = false;

    [DisplayName("Daredevil")]
    [Category("Disadvantage")]
    [Description("\"Daredevil\" from P5S")]
    [DefaultValue(false)]
    public bool d_Daredevil { get; set; } = false;

    [DisplayName("Fatal Desire")]
    [Category("Disadvantage")]
    [Description("\"Fatal Desire\" from P5X")]
    [DefaultValue(false)]
    public bool d_Fatal_Desire { get; set; } = false;

    [DisplayName("Got Your Tail")]
    [Category("Disadvantage")]
    [Description("\"Got Your Tail\" from P5T")]
    [DefaultValue(false)]
    public bool d_Got_Your_Tail { get; set; } = false;

    [DisplayName("Inextinguishable")]
    [Category("Disadvantage")]
    [Description("\"Inextinguishable\" from P5T")]
    [DefaultValue(false)]
    public bool d_Inextinguishable { get; set; } = false;
    
    [DisplayName("Invitation to Freedom")]
    [Category("Disadvantage")]
    [Description("\"Invitation to Freedom\" from PQ2")]
    [DefaultValue(false)]
    public bool d_Invitation_to_Freedom { get; set; } = false;
    
    [DisplayName("It's Too Late")]
    [Category("Disadvantage")]
    [Description("\"It's Too Late\" from P5A")]
    [DefaultValue(true)]
    public bool d_Its_Too_Late { get; set; } = true;
    
    [DisplayName("Last Strike")]
    [Category("Disadvantage")]
    [Description("\"Last Strike\" from P5X")]
    [DefaultValue(false)]
    public bool d_Last_Strike { get; set; } = false;

    [DisplayName("Last Surprise")]
    [Category("Disadvantage")]
    [Description("\"Last Surprise\" from P5")]
    [DefaultValue(false)]
    public bool d_Last_Surprise { get; set; } = false;

    [DisplayName("Last Surprise -Scramble-")]
    [Category("Disadvantage")]
    [Description("\"Last Surprise -Scramble-\" from P5S")]
    [DefaultValue(false)]
    public bool d_Last_SurpriseS { get; set; } = false;

    [DisplayName("Revolution in Your Heart")]
    [Category("Disadvantage")]
    [Description("\"Revolution in Your Heart\" from P5T")]
    [DefaultValue(false)]
    public bool d_Revolution_in_your_Heart { get; set; } = false;

    [DisplayName("Revolution is a Blade")]
    [Category("Disadvantage")]
    [Description("\"Revolution is a Blade\" from P5T")]
    [DefaultValue(true)]
    public bool d_Revolution_is_a_Blade { get; set; } = true;

    [DisplayName("Shadow Loop")]
    [Category("Disadvantage")]
    [Description("\"Shadow Loop\" from P5X")]
    [DefaultValue(false)]
    public bool d_Shadow_Loop { get; set; } = false;

    [DisplayName("Take Over")]
    [Category("Disadvantage")]
    [Description("\"Take Over\" from P5R")]
    [DefaultValue(false)]
    public bool d_Take_Over { get; set; } = false;

    [DisplayName("The Night We Stood")]
    [Category("Disadvantage")]
    [Description("\"The Night We Stood\" from P5T")]
    [DefaultValue(true)]
    public bool d_The_Night_We_Stood { get; set; } = true;

    [DisplayName("Truth or Dare")]
    [Category("Disadvantage")]
    [Description("\"Truth or Dare\" from P5T")]
    [DefaultValue(false)]
    public bool d_Truth_or_Dare { get; set; } = false;

    [DisplayName("Wake Up Your Hero")]
    [Category("Disadvantage")]
    [Description("\"Wake Up Your Hero\" from P5X")]
    [DefaultValue(false)]
    public bool d_Wake_Up_Your_Hero { get; set; } = false;

    [DisplayName("What You Wish For")]
    [Category("Disadvantage")]
    [Description("\"What You Wish For\" from P5S")]
    [DefaultValue(false)]
    public bool d_What_You_Wish_For { get; set; } = false;

    [DisplayName("You Are Stronger")]
    [Category("Disadvantage")]
    [Description("\"You Are Stronger\" from P5S")]
    [DefaultValue(false)]
    public bool d_You_Are_Stronger { get; set; } = false;

    [DisplayName("[Non-Vocal] Desire Surrender")]
    [Category("Disadvantage")]
    [Description("\"Desire Surrender\" from P5X")]
    [DefaultValue(true)]
    public bool d_Desire_Surrender { get; set; } = true;

    [DisplayName("[Non-Vocal] Prison Labor")]
    [Category("Disadvantage")]
    [Description("\"Prison Labor\" from P5R")]
    [DefaultValue(true)]
    public bool d_Prison_Labor { get; set; } = true;

/// NORMAL

    [DisplayName("Axe to Grind")]
    [Category("Normal")]
    [Description("\"Axe to Grind\" from P5S")]
    [DefaultValue(false)]
    public bool n_Axe_to_Grind { get; set; } = false;

    [DisplayName("Counter Strike")]
    [Category("Normal")]
    [Description("\"Counter Strike\" from P5S")]
    [DefaultValue(false)]
    public bool n_Counter_Strike { get; set; } = false;

    [DisplayName("Daredevil")]
    [Category("Normal")]
    [Description("\"Daredevil\" from P5S")]
    [DefaultValue(false)]
    public bool n_Daredevil { get; set; } = false;

    [DisplayName("Fatal Desire")]
    [Category("Normal")]
    [Description("\"Fatal Desire\" from P5X")]
    [DefaultValue(false)]
    public bool n_Fatal_Desire { get; set; } = false;

    [DisplayName("Got Your Tail")]
    [Category("Normal")]
    [Description("\"Got Your Tail\" from P5T")]
    [DefaultValue(true)]
    public bool n_Got_Your_Tail { get; set; } = true;

    [DisplayName("Inextinguishable")]
    [Category("Normal")]
    [Description("\"Inextinguishable\" from P5T")]
    [DefaultValue(false)]
    public bool n_Inextinguishable { get; set; } = false;
    
    [DisplayName("Invitation to Freedom")]
    [Category("Normal")]
    [Description("\"Invitation to Freedom\" from PQ2")]
    [DefaultValue(false)]
    public bool n_Invitation_to_Freedom { get; set; } = false;
    
    [DisplayName("It's Too Late")]
    [Category("Normal")]
    [Description("\"It's Too Late\" from P5A")]
    [DefaultValue(false)]
    public bool n_Its_Too_Late { get; set; } = false;
    
    [DisplayName("Last Strike")]
    [Category("Normal")]
    [Description("\"Last Strike\" from P5X")]
    [DefaultValue(false)]
    public bool n_Last_Strike { get; set; } = false;

    [DisplayName("Last Surprise")]
    [Category("Normal")]
    [Description("\"Last Surprise\" from P5")]
    [DefaultValue(true)]
    public bool n_Last_Surprise { get; set; } = true;

    [DisplayName("Last Surprise -Scramble-")]
    [Category("Normal")]
    [Description("\"Last Surprise -Scramble-\" from P5S")]
    [DefaultValue(true)]
    public bool n_Last_SurpriseS { get; set; } = true;

    [DisplayName("Revolution in Your Heart")]
    [Category("Normal")]
    [Description("\"Revolution in Your Heart\" from P5T")]
    [DefaultValue(true)]
    public bool n_Revolution_in_your_Heart { get; set; } = true;

    [DisplayName("Revolution is a Blade")]
    [Category("Normal")]
    [Description("\"Revolution is a Blade\" from P5T")]
    [DefaultValue(false)]
    public bool n_Revolution_is_a_Blade { get; set; } = false;

    [DisplayName("Shadow Loop")]
    [Category("Normal")]
    [Description("\"Shadow Loop\" from P5X")]
    [DefaultValue(false)]
    public bool n_Shadow_Loop { get; set; } = false;

    [DisplayName("Take Over")]
    [Category("Normal")]
    [Description("\"Take Over\" from P5R")]
    [DefaultValue(false)]
    public bool n_Take_Over { get; set; } = false;

    [DisplayName("The Night We Stood")]
    [Category("Normal")]
    [Description("\"The Night We Stood\" from P5T")]
    [DefaultValue(false)]
    public bool n_The_Night_We_Stood { get; set; } = false;

    [DisplayName("Truth or Dare")]
    [Category("Normal")]
    [Description("\"Truth or Dare\" from P5T")]
    [DefaultValue(true)]
    public bool n_Truth_or_Dare { get; set; } = true;

    [DisplayName("Wake Up Your Hero")]
    [Category("Normal")]
    [Description("\"Wake Up Your Hero\" from P5X")]
    [DefaultValue(false)]
    public bool n_Wake_Up_Your_Hero { get; set; } = false;

    [DisplayName("What You Wish For")]
    [Category("Normal")]
    [Description("\"What You Wish For\" from P5S")]
    [DefaultValue(false)]
    public bool n_What_You_Wish_For { get; set; } = false;

    [DisplayName("You Are Stronger")]
    [Category("Normal")]
    [Description("\"You Are Stronger\" from P5S")]
    [DefaultValue(false)]
    public bool n_You_Are_Stronger { get; set; } = false;

    [DisplayName("[Non-Vocal] Desire Surrender")]
    [Category("Normal")]
    [Description("\"Desire Surrender\" from P5X")]
    [DefaultValue(false)]
    public bool n_Desire_Surrender { get; set; } = false;

    [DisplayName("[Non-Vocal] Prison Labor")]
    [Category("Normal")]
    [Description("\"Prison Labor\" from P5R")]
    [DefaultValue(false)]
    public bool n_Prison_Labor { get; set; } = false;

}

/// <summary>
/// Allows you to override certain aspects of the configuration creation process (e.g. create multiple configurations).
/// Override elements in <see cref="ConfiguratorMixinBase"/> for finer control.
/// </summary>
public class ConfiguratorMixin : ConfiguratorMixinBase
{
    // 
}
