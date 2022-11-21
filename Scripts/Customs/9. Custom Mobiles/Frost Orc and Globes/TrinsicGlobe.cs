using System;
using Server;
using Server.Mobiles;
using Server.Gumps;

namespace Server.Items
{
	public class TrinsicGlobe : SnowGlobe
	{
		[Constructable]
		public TrinsicGlobe() 
		{
			Name = "a Snowy Scene of Trinsic"; 
		}

		public TrinsicGlobe( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}