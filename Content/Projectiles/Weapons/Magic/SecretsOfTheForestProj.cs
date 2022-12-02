using Terraria;
using Terraria.ID;
using Terraria.Audio;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Forestation.Content.Projectiles.Weapons.Magic;
internal class SecretsOfTheForestProj : ModProjectile
{
    public override void SetDefaults()
    { 
            Projectile.width = 16;
            Projectile.height = 16;

            Projectile.friendly = true;
            Projectile.DamageType = DamageClass.Magic;

        
        
        Projectile.aiStyle = -1;
        Projectile.penetrate = 1;
    }

    public override bool OnTileCollide(Vector2 oldVelocity)
    {
        Projectile.penetrate--;
        if(Projectile.penetrate < 0)
            Projectile.Kill();

    return true;
    }

    public override void AI()
    {
        Projectile.velocity *= 1.02f;

        if(Main.rand.NextBool(2))
        {
            int spawn = Main.rand.Next(3);
            for(int i = 0; i < spawn; i++)
                Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.t_BorealWood);
        }

    }

    public override void Kill(int timeLeft)
    {
        Collision.HitTiles(Projectile.position + Projectile.velocity, Projectile.velocity, Projectile.width, Projectile.height);
        SoundEngine.PlaySound(SoundID.Grass, Projectile.position);

        int spawn = Main.rand.Next(6);
        for(int i = 0; i < spawn; i++)
            Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.t_Cactus);
    }   
}