using System;
using Server;
using Server.Items;
using Server.Targeting;

namespace Server.Mobiles
{
	[CorpseName( "a werewolf corpse" )]
	public class Werewolf5 : BaseCreature
	{
		private bool m_TrueForm;

		[Constructable]
		public Werewolf5() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a werewolf";
			Body = 719;
			SetStr( 1200, 1400 );
			SetDex( 450, 600 );
			SetInt( 1600, 2000 );
			SetHits( 2800, 3600 );
			SetDamage( 24, 36 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 50, 80 );
			SetResistance( ResistanceType.Fire, 30, 45 );
			SetResistance( ResistanceType.Cold, 60, 90 );
			SetResistance( ResistanceType.Poison, 60, 90 );
			SetResistance( ResistanceType.Energy, 50, 80 );

			SetSkill( SkillName.EvalInt, 140.0, 165.0 );
			SetSkill( SkillName.Magery, 140.0, 165.0 );
			SetSkill( SkillName.Necromancy, 130.0, 160.0 );
			SetSkill( SkillName.SpiritSpeak, 100.0, 105.0 );
			SetSkill( SkillName.MagicResist, 140.0, 180.0 );
			SetSkill( SkillName.Tactics, 160.0, 200.0 );
			SetSkill( SkillName.Wrestling, 160.1, 200.0 );
			SetSkill( SkillName.DetectHidden, 85.0, 95.0 );

			VirtualArmor = 55;
		}
			
		public void Morph()
		{
			if (m_TrueForm)
				return;

			m_TrueForm = true;
			if ( this.Female = Utility.RandomBool() )
			{
				Body = 0x191;
				Name = NameList.RandomName( "female" );
				WerewolfLegWraps1 LegWraps = new WerewolfLegWraps1();
				LegWraps.Name = "Ancient Werewolf Legwraps";
				LegWraps.Movable = false;
				AddItem(LegWraps);
			}
			else
			{
				Body = 0x190;
				Name = NameList.RandomName( "male" );
				WerewolfLegs1 Legs = new WerewolfLegs1();
				Legs.Name = "Ancient Werewolf Leggings";
				Legs.Movable = false;
				AddItem(Legs);
			}

			Title = "the Werewolf";
			SpeechHue = Utility.RandomDyedHue();
			Hue = Utility.RandomSkinHue();
			SetStr( 600, 700 );
			SetDex( 225, 300 );
			SetInt( 800, 1000 );
			Hits = HitsMax;
			Stam = StamMax;
			Mana = ManaMax;
			SetDamage( 20, 34 );
			
			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 50, 80 );
			SetResistance( ResistanceType.Fire, 30, 45 );
			SetResistance( ResistanceType.Cold, 60, 90 );
			SetResistance( ResistanceType.Poison, 60, 90 );
			SetResistance( ResistanceType.Energy, 50, 80 );

			SetSkill( SkillName.EvalInt, 140.0, 165.0 );
			SetSkill( SkillName.Magery, 140.0, 165.0 );
			SetSkill( SkillName.Necromancy, 130.0, 160.0 );
			SetSkill( SkillName.SpiritSpeak, 100.0, 105.0 );
			SetSkill( SkillName.MagicResist, 140.0, 180.0 );
			SetSkill( SkillName.Tactics, 160.0, 200.0 );
			SetSkill( SkillName.Wrestling, 160.1, 200.0 );
			SetSkill( SkillName.DetectHidden, 85.0, 95.0 );

			Fame = 3200;
			Karma = -3200;

			VirtualArmor = 45;
			Tamable = false;
			ProcessDelta();
			
			WerewolfGorget1 Gorget = new WerewolfGorget1();
			Gorget.Movable = false;
			Gorget.Name = "Ancient Werewolf Collar";
			AddItem(Gorget);

			WerewolfChest1 Chest = new WerewolfChest1();
			Chest.Name = "Ancient Werewolf Tunic";
			Chest.Movable = false;
			AddItem(Chest);

			WerewolfArms1 Arms = new WerewolfArms1();
			Arms.Name = "Ancient Werewolf Armguards";
			Arms.Movable = false;
			AddItem(Arms);

			WerewolfGloves1 Gloves = new WerewolfGloves1();
			Gloves.Movable = false;
			Gloves.Name = "Ancient Werewolf Gloves";
			AddItem(Gloves);
				
			//This dresses the Werewolf, Note TatteredClothes are not movable and do not show up on the corpse
			switch ( Utility.Random( 2 ))
			{
				case 0: AddItem( new  TatteredCloak() ); break;
				default: break;
			}
			switch ( Utility.Random( 4 ))
			{
			//Assassin Only
				//case 0: AddItem( new  TatteredClothNinjaHood() ); break;
				case 0: AddItem( new  TatteredCap() ); break;
				case 1: AddItem( new  TatteredSkullCap() ); break;
				case 2: AddItem( new  TatteredBandana() ); break;
				case 3: AddItem( new  TatteredBonnet() ); break;
			// Archmage Only
				//case 5: AddItem( new  TatteredMagicWizardsHat() ); break;
				default: break;
			}
			switch ( Utility.Random( 3 ))
			{
				case 0: AddItem( new  TatteredFullApron() ); break;
				case 1: AddItem( new  TatteredDoublet() ); break;
				// Knight Only
				//case 2: AddItem( new  TatteredSurcoat() ); break;
				// Knight Only
				//case 3: AddItem( new  TatteredTunic() ); break;
				case 2: AddItem( new  TatteredJinBaori() ); break;
				default: break;
			}
			switch ( Utility.Random( 2 ))
			{
				// Patrician Only
				//case 0: AddItem( new  TatteredFancyDress () ); break;
				// Patrician Only
				//case 1: AddItem( new  TatteredKamishimo  () ); break;
				case 0: AddItem( new  TatteredHakamaShita  () ); break;
				case 1: AddItem( new  TatteredPlainDress  () ); break;
				// Elder Only
				//case 4: AddItem( new  TatteredMaleKimono  () ); break;
				// Elder Only
				//case 5: AddItem( new  TatteredFemaleKimono () ); break;
				  default: break;
			}

			switch ( Utility.Random( 3 ))
			{
				case 0: AddItem( new  TatteredFancyShirt() ); break;
				//Assassin Only
				//case 1: AddItem( new  TatteredClothNinjaJacket() ); break;
				case 1: AddItem( new  TatteredShirt() ); break;
				case 2: AddItem( new  TatteredElvenDarkShirt() ); break;	
				default: break;
			}
			switch ( Utility.Random( 5 ))
			{
				case 0: AddItem( new  TatteredThighBoots () ); break;
				case 1: AddItem( new  TatteredSandals () ); break;
				case 2: AddItem( new  TatteredNinjaTabi  () ); break;
				case 3: AddItem( new  TatteredElvenBoots() ); break;
				case 4: AddItem( new  TatteredShoes() ); break;
				default: break;
			}
			switch ( Utility.Random( 3 ))
			{
				case 0: AddItem( new  TatteredWoodlandBelt() ); break;
				case 1: AddItem( new  TatteredObi() ); break;
				case 2: AddItem( new  TatteredHalfApron () ); break;
				default: break;
			}
			// End Werewolf Dressing Block
			if (Utility.RandomDouble() < 0.2)
			{
				switch ( Utility.Random( 4 ))
				{
					case 0: PackItem( new   WerewolfArms5() ); break;
					case 1: PackItem( new  WerewolfChest5() ); break;
					case 2: PackItem( new WerewolfGloves5() ); break;
					case 3: PackItem( new WerewolfGorget5() ); break;
					case 4:
					{
						if (!this.Female)
							{PackItem( new WerewolfLegs5() ); break;}
						else
							{PackItem( new WerewolfLegWraps5() ); break;}
					}
					default: break;
				}
			}
			Utility.AssignRandomHair( this );
		}
		[CommandProperty( AccessLevel.GameMaster )]
		public override int HitsMax{ get{ return m_TrueForm ? 1400 : 1800; } }
		
		[CommandProperty( AccessLevel.GameMaster )]
		public override int ManaMax{ get{ return 500; } }

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich );
			AddLoot( LootPack.MedScrolls, 2 );
		}

		public override bool CanRummageCorpses{ get{ return true; } }
		public override bool BleedImmune{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Lethal; } }
		public override int TreasureMapLevel{ get{ return 5; } }
		public override bool AlwaysMurderer{ get{ return true; } }

		public Werewolf5( Serial serial ) : base( serial )
		{
		}

		public override bool OnBeforeDeath()
		{
			if ( m_TrueForm )
			{
				return base.OnBeforeDeath();
			}
			else
			{
				Morph();
				return false;
			}
		}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
			writer.Write( m_TrueForm );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
			switch ( version )
			{
				case 0:
				{
					m_TrueForm = reader.ReadBool();

					break;
				}
			}
		}

		//these two allow werewolves to reveal hidden players
	    private Mobile FindTarget()
        {
        	foreach (Mobile m in this.GetMobilesInRange(1))
	        {
                if (m.Player && m.Hidden && m.AccessLevel == AccessLevel.Player)
           	    {
                	return m;
        	    }
	        }
	        return null;
	    }

	    private void TryToDetectHidden()
        {
	        Mobile m = FindTarget();

        	if (m != null)
	        {
                if (DateTime.Now >= this.NextSkillTime && UseSkill(SkillName.DetectHidden))
        	    {
	                Target targ = this.Target;

                	if (targ != null)
        	            targ.Invoke(this, this);
	
	                Effects.PlaySound(this.Location, this.Map, 0x340);
                }
        	}
	    }

	    public override void OnThink()
		{
            if (Utility.RandomDouble() < 0.2)
        	    TryToDetectHidden();
	    }
	}
}