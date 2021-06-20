using Terraria.ModLoader;

namespace NoMoreProjectiles
{
	public class Projectile : GlobalProjectile
	{
		public override void SetDefaults(Terraria.Projectile projectile) {
			projectile.Kill();
		}
	}
}