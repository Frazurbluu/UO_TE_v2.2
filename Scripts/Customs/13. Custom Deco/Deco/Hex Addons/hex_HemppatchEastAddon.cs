
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class hex_HemppatchEastAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {5368, 0, 1, 1}, {4090, 2, -1, 3}, {2324, -1, -1, 1}// 5	6	7	
			, {2324, -1, 0, 1}, {2324, -1, 1, 1}, {2324, 0, -1, 1}// 8	9	10	
			, {2324, 0, 0, 1}, {2324, 0, 1, 1}, {2324, 1, -1, 1}// 11	12	13	
			, {2324, 1, 0, 1}, {2324, 1, 1, 1}, {2324, 2, -1, 1}// 14	15	16	
			, {2324, 2, 0, 1}, {2324, 2, 1, 1}, {6018, 0, 1, 1}// 17	18	19	
			, {6018, 1, 1, 1}, {6020, 0, -1, 1}, {6020, 1, -1, 1}// 20	21	22	
			, {6022, -1, 1, 1}, {6023, -1, -1, 1}, {6024, 2, -1, 1}// 23	24	25	
			, {6025, 2, 1, 1}, {6019, 2, 0, 1}, {6018, -1, -2, 0}// 26	27	28	
			, {6018, 0, -2, 0}, {6018, 1, -2, 0}, {6018, 2, -2, 0}// 29	30	31	
			, {6019, -2, -1, 0}, {6019, -2, 0, 0}, {6019, -2, 1, 0}// 32	33	34	
			, {6020, -1, 2, 0}, {6020, 0, 2, 0}, {6020, 1, 2, 0}// 35	36	37	
			, {6020, 2, 2, 0}, {6021, 3, -1, 0}, {6021, 3, 0, 0}// 38	39	40	
			, {6021, 3, 1, 0}// 41	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new hex_HemppatchEastAddonDeed();
			}
		}

		[ Constructable ]
		public hex_HemppatchEastAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 3220, 0, 0, 2, 663, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 3220, 1, 0, 2, 663, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 3220, 2, 0, 2, 663, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 3220, -1, 0, 2, 663, -1, "", 1);// 4

		}

		public hex_HemppatchEastAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
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

	public class hex_HemppatchEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new hex_HemppatchEastAddon();
			}
		}

		[Constructable]
		public hex_HemppatchEastAddonDeed()
		{
			Name = "Hemp patch East";
		}

		public hex_HemppatchEastAddonDeed( Serial serial ) : base( serial )
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