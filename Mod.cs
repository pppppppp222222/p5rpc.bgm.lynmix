using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using p5rpc.bgm.lynmix.Template;
using p5rpc.bgm.lynmix.Configuration;
using BGME.BattleThemes.Interfaces;

namespace p5rpc.bgm.lynmix;

/// <summary>
/// Your mod logic goes here.
/// </summary>
public class Mod : ModBase // <= Do not Remove.
{
    /// <summary>
    /// Provides access to the mod loader API.
    /// </summary>
    private readonly IModLoader _modLoader;

    /// <summary>
    /// Provides access to the Reloaded.Hooks API.
    /// </summary>
    /// <remarks>This is null if you remove dependency on Reloaded.SharedLib.Hooks in your mod.</remarks>
    private readonly IReloadedHooks? _hooks;

    /// <summary>
    /// Provides access to the Reloaded logger.
    /// </summary>
    private readonly ILogger _logger;

    /// <summary>
    /// Entry point into the mod, instance that created this class.
    /// </summary>
    private readonly IMod _owner;

    /// <summary>
    /// Provides access to this mod's configuration.
    /// </summary>
    private Config _configuration;

    /// <summary>
    /// The configuration of the currently executing mod.
    /// </summary>
    private readonly IModConfig _modConfig;

    public Mod(ModContext context)
    {
        _modLoader = context.ModLoader;
        _hooks = context.Hooks;
        _logger = context.Logger;
        _owner = context.Owner;
        _configuration = context.Configuration;
        _modConfig = context.ModConfig;

        // For more information about this template, please see
        // https://reloaded-project.github.io/Reloaded-II/ModTemplate/

        // If you want to implement e.g. unload support in your mod,
        // and some other neat features, override the methods in ModBase.

        // TODO: Implement some mod logic
        var normalSongsList = new List<string>();
        var ambushSongsList = new List<string>();
        var disadvantageSongsList = new List<string>();
        var properties = typeof(Config).GetProperties()
            .Where(p => p.PropertyType == typeof(bool));
        foreach (var prop in properties)
        {
            bool isEnabled = (bool)prop.GetValue(_configuration);
            if (!isEnabled) continue;
            string songName = prop.Name.Substring(2);
            switch (prop.Name[0])
            {
                case 'n':
                    normalSongsList.Add(songName);
                    break;
                case 'a':
                    ambushSongsList.Add(songName);
                    break;
                case 'd':
                    disadvantageSongsList.Add(songName);
                    break;
            }
        }
        if (normalSongsList.Count != 0 && ambushSongsList.Count != 0 && disadvantageSongsList.Count != 0) {
            var script = $"const normal_tracks = [{string.Join(", ", normalSongsList)}]\nconst ambush_tracks = [{string.Join(", ", ambushSongsList)}]\nconst disadvantage_tracks = [{string.Join(", ", disadvantageSongsList)}]\n\nconst BATTLE_THEME = battle_bgm(random_song(normal_tracks), random_song(ambush_tracks), random_song(disadvantage_tracks))";
            var modDir = _modLoader.GetDirectoryForModId(_modConfig.ModId);
            var outputFile = Path.Join(modDir, "battle-themes/custom/output.theme.pme");
            File.WriteAllText(outputFile, script);
            _modLoader.GetController<IBattleThemesApi>().TryGetTarget(out var themesApi);
            themesApi.AddPath(_modConfig.ModId, outputFile);
            _logger.WriteLine($"[{_modConfig.ModId}] Music script generated for Lyn Mix.");
        }
        else {
            _logger.WriteLine($"[{_modConfig.ModId}] At least one song must be enabled in each category for Lyn Mix to work.");
        }
    }

    #region Standard Overrides
    public override void ConfigurationUpdated(Config configuration)
    {
        // Apply settings from configuration.
        // ... your code here.
        _configuration = configuration;
        _logger.WriteLine($"[{_modConfig.ModId}] Config Updated: Applying");
    }
    #endregion

    #region For Exports, Serialization etc.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public Mod() { }
#pragma warning restore CS8618
    #endregion
}