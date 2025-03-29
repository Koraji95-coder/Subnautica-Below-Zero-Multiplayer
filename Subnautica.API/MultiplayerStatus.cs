using Subnautica.Network;

namespace Subnautica.API
{
    public static class MultiplayerStatus
    {
        public static bool IsInMultiplayer =>
            MultiplayerManager.instance?.isConnected ?? false;

        public static bool IsHost =>
            MultiplayerManager.instance?.isHost ?? false;

        public static bool IsClient =>
            MultiplayerManager.instance?.isClient ?? false;

        public static string PlayerId =>
            MultiplayerManager.instance?.playerId ?? "UNKNOWN";
    }
}
