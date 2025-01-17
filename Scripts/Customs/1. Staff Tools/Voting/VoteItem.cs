﻿using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Server.Misc;
using Server.Gumps;
using Server.Items;
using Server.Mobiles;
using Server.Accounting;

namespace Server.Voting
{
	/// <summary>
	/// Provides a derivable class to create items that hold VoteSites and to handle Voting.
	/// </summary>
	public class VoteItem : Item
	{
		private static VoteItem _Instance;
		/// <summary>
		/// Gets an instance of VoteItem that can be used to allow voting without the need of an ingame object.
		/// </summary>
		public static VoteItem Instance
		{
			get
			{
				if (_Instance == null || _Instance.Deleted)
				{
					_Instance = new VoteItem(0);
					_Instance.Movable = false;
					_Instance.Visible = false;
					_Instance.Internalize();
				}

				return _Instance;
			}
		}

		private bool _Messages = true;
		/// <summary>
		/// Gets or Sets a value indecating whether messages should be sent to a vote request sender on various events.
		/// </summary>
		[CommandProperty(AccessLevel.GameMaster)]
		public bool Messages { get { return _Messages; } set { _Messages = value; } }

		private VoteSite _VoteSite;
		/// <summary>
		/// Gets or Sets the vote website profile. 
		/// Exposes options to configure the vote site, such as Name and URL.
		/// </summary>
		[CommandProperty(AccessLevel.GameMaster)]
		public VoteSite VoteSite
		{
			get
			{
				if (_VoteSite == null)
					_VoteSite = new VoteSite(this);

				return _VoteSite;
			}
			set
			{
				_VoteSite = value;
				InvalidateProperties();
			}
		}

		public VoteItem(int itemID)
			: base(itemID)
		{ }

		public VoteItem(Serial serial)
			: base(serial)
		{ }

		public virtual void CastVote(Mobile from)
		{
			VoteHelper.CastVote(from, VoteSite);
		}

		public virtual void OnVote(Mobile from, VoteStatus status)
		{
			if (status == VoteStatus.Success && VoteSite.Valid)
			{
				if (_Messages)
					from.SendMessage("Thank you for voting on {0}!", VoteSite.Name);

				from.LaunchBrowser(VoteSite.URL);
				VoteHelper.SetLastVoteTime(from, VoteSite);
			}
			else if (status == VoteStatus.TooEarly)
			{
				if (_Messages)
				{
					TimeSpan timeLeft = VoteHelper.GetTimeLeft(from, VoteSite);
					from.SendMessage(0x22, "Sorry, you can not vote on {0} for {1}.", VoteSite.Name, VoteHelper.GetFormattedTime(timeLeft));
				}
			}
			else if (status == VoteStatus.Invalid)
			{
				if (_Messages)
				{
					from.SendMessage(0x22, "Sorry, voting is currently unavailable.");
				}
			}
		}

		public virtual bool OnBeforeVote(Mobile from)
		{ return true; }

		public virtual void OnAfterVote(Mobile from, VoteStatus status)
		{ }

		public override void OnDoubleClick(Mobile from)
		{
			base.OnDoubleClick(from);

			CastVote(from);
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int)0);

			writer.Write((bool)_Messages);

			VoteSite.Serialize(writer);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();

			switch (version)
			{
				case 0:
					{
						_Messages = reader.ReadBool();

						VoteSite.Deserialize(reader);
					} break;
			}
		}
	}
}
