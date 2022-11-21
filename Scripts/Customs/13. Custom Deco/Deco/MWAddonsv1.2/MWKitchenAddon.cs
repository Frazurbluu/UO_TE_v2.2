/////////////////////////////////////////////////
//                                             //
// Automatically generated by the              //
// AddonGenerator script by Arya               //
//                                             //
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class MWKitchenAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new MWKitchenAddonDeed();
			}
		}

		[ Constructable ]
		public MWKitchenAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 2639 );
			ac.Hue = 2505;
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 1981 );
			ac.Hue = 2565;
			AddComponent( ac, -1, -2, 5 );
			ac = new AddonComponent( 1982 );
			ac.Hue = 2565;
			AddComponent( ac, 0, -2, 5 );
			ac = new AddonComponent( 1982 );
			ac.Hue = 2565;
			AddComponent( ac, 1, -2, 5 );
			ac = new AddonComponent( 1981 );
			ac.Hue = 2565;
			AddComponent( ac, -1, 1, 5 );
			ac = new AddonComponent( 2884 );
			AddComponent( ac, -1, 0, 5 );
			ac = new AddonComponent( 2478 );
			AddComponent( ac, -1, 1, 7 );
			ac = new AddonComponent( 2451 );
			AddComponent( ac, -1, -2, 7 );
			ac = new AddonComponent( 9441 );
			AddComponent( ac, 0, -2, 7 );
			ac = new AddonComponent( 2522 );
			AddComponent( ac, -1, 1, 8 );
			ac = new AddonComponent( 2478 );
			AddComponent( ac, -1, 1, 7 );
			ac = new AddonComponent( 2585 );
			AddComponent( ac, -1, 1, 7 );
			ac = new AddonComponent( 2639 );
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 2451 );
			AddComponent( ac, -1, -2, 7 );
			ac = new AddonComponent( 9441 );
			AddComponent( ac, 0, -2, 7 );
			ac = new AddonComponent( 2884 );
			AddComponent( ac, -1, 0, 5 );
			ac = new AddonComponent( 4100 );
			AddComponent( ac, -1, 0, 11 );
			ac = new AddonComponent( 2522 );
			AddComponent( ac, -1, 1, 8 );
			ac = new AddonComponent( 1981 );
			ac.Hue = 2565;
			AddComponent( ac, -1, -1, 5 );
			ac = new AddonComponent( 4100 );
			AddComponent( ac, -1, 0, 11 );
			ac = new AddonComponent( 2585 );
			AddComponent( ac, -1, 1, 7 );
			ac = new AddonComponent( 1986 );
			ac.Hue = 2565;
			AddComponent( ac, -1, 2, 5 );

		}

		public MWKitchenAddon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class MWKitchenAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new MWKitchenAddon();
			}
		}

		[Constructable]
		public MWKitchenAddonDeed()
		{
			Name = "Kitchen";
		}

		public MWKitchenAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}