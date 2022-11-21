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
	public class SV_Corridor_WestAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,]
		{
			{4395, 0, 0, 30}, {4395, 1, 0, 30}, {4395, -1, 0, 30}// 330	331	332	
			, {4395, -2, 0, 30}, {4395, 2, 0, 30}, {4395, 4, 0, 30}// 333	334	335	
			, {4395, 3, 0, 30}, {4650, 4, 1, 30}, {4653, -2, 0, 30}// 336	338	339	
			, {5701, 1, 0, 30}, {6924, -1, 1, 30}, {6937, 4, 1, 30}// 340	341	342	
		};

		public override BaseAddonDeed Deed
		{
			get
			{
				return new SV_Corridor_WestAddonDeed();
			}
		}

		[ Constructable ]
		public SV_Corridor_WestAddon()
		{
            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );

			AddComplexComponent( (BaseAddon) this, 1955, -6, 0, 0, 1105, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 1955, -6, 1, 0, 1105, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 1955, -6, 2, 0, 1105, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 1955, -5, 0, 0, 1105, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 1955, -5, 1, 0, 1105, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1955, -5, 2, 0, 1105, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1955, -5, 3, 0, 1105, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 1955, -4, 0, 0, 1105, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 1955, -4, 1, 0, 1105, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1955, -4, 2, 0, 1105, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 1955, -4, 3, 0, 1105, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 1955, -3, 0, 0, 1105, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 1955, -3, 1, 0, 1105, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 1955, -3, 2, 0, 1105, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 1955, -3, 3, 0, 1105, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 1955, -6, 0, 5, 1105, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 1955, -6, 1, 5, 1105, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 1955, -6, 2, 5, 1105, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 1955, -5, 0, 5, 1105, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 1955, -5, 1, 5, 1105, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 1955, -5, 2, 5, 1105, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 1955, -5, 3, 5, 1105, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 1955, -4, 0, 5, 1105, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 1955, -4, 1, 5, 1105, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 1955, -4, 2, 5, 1105, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 1955, -4, 3, 5, 1105, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 1955, -3, 0, 5, 1105, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 1955, -3, 1, 5, 1105, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 1955, -3, 2, 5, 1105, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 1955, -3, 3, 5, 1105, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 1955, -5, 0, 10, 1105, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 1955, -5, 1, 10, 1105, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 1955, -5, 2, 10, 1105, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 1955, -5, 3, 10, 1105, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 1955, -4, 0, 10, 1105, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 1955, -4, 1, 10, 1105, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 1955, -4, 2, 10, 1105, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 1955, -4, 3, 10, 1105, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 1955, -3, 0, 10, 1105, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 1955, -3, 1, 10, 1105, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 1955, -3, 2, 10, 1105, -1, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 1955, -3, 3, 10, 1105, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 1955, -5, 0, 15, 1105, -1, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 1955, -5, 1, 15, 1105, -1, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 1955, -5, 2, 15, 1105, -1, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 1955, -5, 3, 15, 1105, -1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 1955, -4, 0, 15, 1105, -1, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 1955, -4, 1, 15, 1105, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 1955, -4, 2, 15, 1105, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 1955, -4, 3, 15, 1105, -1, "", 1);// 50
			AddComplexComponent( (BaseAddon) this, 1955, -3, 0, 15, 1105, -1, "", 1);// 51
			AddComplexComponent( (BaseAddon) this, 1955, -3, 1, 15, 1105, -1, "", 1);// 52
			AddComplexComponent( (BaseAddon) this, 1955, -3, 2, 15, 1105, -1, "", 1);// 53
			AddComplexComponent( (BaseAddon) this, 1955, -3, 3, 15, 1105, -1, "", 1);// 54
			AddComplexComponent( (BaseAddon) this, 1955, -4, 0, 20, 1105, -1, "", 1);// 55
			AddComplexComponent( (BaseAddon) this, 1955, -4, 1, 20, 1105, -1, "", 1);// 56
			AddComplexComponent( (BaseAddon) this, 1955, -4, 2, 20, 1105, -1, "", 1);// 57
			AddComplexComponent( (BaseAddon) this, 1955, -4, 3, 20, 1105, -1, "", 1);// 58
			AddComplexComponent( (BaseAddon) this, 1955, -3, 0, 20, 1105, -1, "", 1);// 59
			AddComplexComponent( (BaseAddon) this, 1955, -3, 1, 20, 1105, -1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 1955, -3, 2, 20, 1105, -1, "", 1);// 61
			AddComplexComponent( (BaseAddon) this, 1955, -3, 3, 20, 1105, -1, "", 1);// 62
			AddComplexComponent( (BaseAddon) this, 1955, -3, 0, 25, 1105, -1, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 1955, -3, 1, 25, 1105, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 1955, -3, 2, 25, 1105, -1, "", 1);// 65
			AddComplexComponent( (BaseAddon) this, 1955, -3, 3, 25, 1105, -1, "", 1);// 66
			AddComplexComponent( (BaseAddon) this, 1959, -5, 0, 20, 1105, -1, "", 1);// 67
			AddComplexComponent( (BaseAddon) this, 1959, -5, 1, 20, 1105, -1, "", 1);// 68
			AddComplexComponent( (BaseAddon) this, 1959, -5, 2, 20, 1105, -1, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 1959, -5, 3, 20, 1105, -1, "", 1);// 70
			AddComplexComponent( (BaseAddon) this, 1959, -4, 3, 25, 1105, -1, "", 1);// 71
			AddComplexComponent( (BaseAddon) this, 1959, -4, 2, 25, 1105, -1, "", 1);// 72
			AddComplexComponent( (BaseAddon) this, 1959, -4, 1, 25, 1105, -1, "", 1);// 73
			AddComplexComponent( (BaseAddon) this, 1959, -4, 0, 25, 1105, -1, "", 1);// 74
			AddComplexComponent( (BaseAddon) this, 577, -5, 4, 0, 2051, -1, "", 1);// 75
			AddComplexComponent( (BaseAddon) this, 577, -4, 4, 0, 2051, -1, "", 1);// 76
			AddComplexComponent( (BaseAddon) this, 577, -3, 4, 0, 2051, -1, "", 1);// 77
			AddComplexComponent( (BaseAddon) this, 577, -5, 4, 22, 2051, -1, "", 1);// 78
			AddComplexComponent( (BaseAddon) this, 577, -4, 4, 22, 2051, -1, "", 1);// 79
			AddComplexComponent( (BaseAddon) this, 577, -3, 4, 22, 2051, -1, "", 1);// 80
			AddComplexComponent( (BaseAddon) this, 577, -5, -1, 22, 2051, -1, "", 1);// 81
			AddComplexComponent( (BaseAddon) this, 577, -4, -1, 22, 2051, -1, "", 1);// 82
			AddComplexComponent( (BaseAddon) this, 577, -3, -1, 22, 2051, -1, "", 1);// 83
			AddComplexComponent( (BaseAddon) this, 577, -3, -1, 38, 2051, -1, "", 1);// 84
			AddComplexComponent( (BaseAddon) this, 577, -4, -1, 30, 2051, -1, "", 1);// 85
			AddComplexComponent( (BaseAddon) this, 577, -4, 4, 28, 2051, -1, "", 1);// 86
			AddComplexComponent( (BaseAddon) this, 577, -3, 4, 35, 2051, -1, "", 1);// 87
			AddComplexComponent( (BaseAddon) this, 4825, -3, 0, 30, 2053, -1, "", 1);// 88
			AddComplexComponent( (BaseAddon) this, 1955, 5, 0, 0, 1105, -1, "", 1);// 89
			AddComplexComponent( (BaseAddon) this, 1955, 5, 1, 0, 1105, -1, "", 1);// 90
			AddComplexComponent( (BaseAddon) this, 1955, 5, 2, 0, 1105, -1, "", 1);// 91
			AddComplexComponent( (BaseAddon) this, 1955, 5, 3, 0, 1105, -1, "", 1);// 92
			AddComplexComponent( (BaseAddon) this, 1955, -2, 0, 0, 1105, -1, "", 1);// 93
			AddComplexComponent( (BaseAddon) this, 1955, -2, 1, 0, 1105, -1, "", 1);// 94
			AddComplexComponent( (BaseAddon) this, 1955, -2, 2, 0, 1105, -1, "", 1);// 95
			AddComplexComponent( (BaseAddon) this, 1955, -2, 3, 0, 1105, -1, "", 1);// 96
			AddComplexComponent( (BaseAddon) this, 1955, -1, 0, 0, 1105, -1, "", 1);// 97
			AddComplexComponent( (BaseAddon) this, 1955, -1, 1, 0, 1105, -1, "", 1);// 98
			AddComplexComponent( (BaseAddon) this, 1955, -1, 2, 0, 1105, -1, "", 1);// 99
			AddComplexComponent( (BaseAddon) this, 1955, -1, 3, 0, 1105, -1, "", 1);// 100
			AddComplexComponent( (BaseAddon) this, 1955, 0, 0, 0, 1105, -1, "", 1);// 101
			AddComplexComponent( (BaseAddon) this, 1955, 0, 1, 0, 1105, -1, "", 1);// 102
			AddComplexComponent( (BaseAddon) this, 1955, 0, 2, 0, 1105, -1, "", 1);// 103
			AddComplexComponent( (BaseAddon) this, 1955, 0, 3, 0, 1105, -1, "", 1);// 104
			AddComplexComponent( (BaseAddon) this, 1955, 1, 0, 0, 1105, -1, "", 1);// 105
			AddComplexComponent( (BaseAddon) this, 1955, 1, 1, 0, 1105, -1, "", 1);// 106
			AddComplexComponent( (BaseAddon) this, 1955, 1, 2, 0, 1105, -1, "", 1);// 107
			AddComplexComponent( (BaseAddon) this, 1955, 1, 3, 0, 1105, -1, "", 1);// 108
			AddComplexComponent( (BaseAddon) this, 1955, 2, 0, 0, 1105, -1, "", 1);// 109
			AddComplexComponent( (BaseAddon) this, 1955, 2, 1, 0, 1105, -1, "", 1);// 110
			AddComplexComponent( (BaseAddon) this, 1955, 2, 2, 0, 1105, -1, "", 1);// 111
			AddComplexComponent( (BaseAddon) this, 1955, 2, 3, 0, 1105, -1, "", 1);// 112
			AddComplexComponent( (BaseAddon) this, 1955, 3, 0, 0, 1105, -1, "", 1);// 113
			AddComplexComponent( (BaseAddon) this, 1955, 3, 1, 0, 1105, -1, "", 1);// 114
			AddComplexComponent( (BaseAddon) this, 1955, 3, 2, 0, 1105, -1, "", 1);// 115
			AddComplexComponent( (BaseAddon) this, 1955, 3, 3, 0, 1105, -1, "", 1);// 116
			AddComplexComponent( (BaseAddon) this, 1955, 4, 0, 0, 1105, -1, "", 1);// 117
			AddComplexComponent( (BaseAddon) this, 1955, 4, 1, 0, 1105, -1, "", 1);// 118
			AddComplexComponent( (BaseAddon) this, 1955, 4, 2, 0, 1105, -1, "", 1);// 119
			AddComplexComponent( (BaseAddon) this, 1955, 4, 3, 0, 1105, -1, "", 1);// 120
			AddComplexComponent( (BaseAddon) this, 1955, -2, 0, 5, 1105, -1, "", 1);// 121
			AddComplexComponent( (BaseAddon) this, 1955, -2, 1, 5, 1105, -1, "", 1);// 122
			AddComplexComponent( (BaseAddon) this, 1955, -2, 2, 5, 1105, -1, "", 1);// 123
			AddComplexComponent( (BaseAddon) this, 1955, -2, 3, 5, 1105, -1, "", 1);// 124
			AddComplexComponent( (BaseAddon) this, 1955, -1, 0, 5, 1105, -1, "", 1);// 125
			AddComplexComponent( (BaseAddon) this, 1955, -1, 1, 5, 1105, -1, "", 1);// 126
			AddComplexComponent( (BaseAddon) this, 1955, -1, 2, 5, 1105, -1, "", 1);// 127
			AddComplexComponent( (BaseAddon) this, 1955, -1, 3, 5, 1105, -1, "", 1);// 128
			AddComplexComponent( (BaseAddon) this, 1955, 0, 0, 5, 1105, -1, "", 1);// 129
			AddComplexComponent( (BaseAddon) this, 1955, 0, 1, 5, 1105, -1, "", 1);// 130
			AddComplexComponent( (BaseAddon) this, 1955, 0, 2, 5, 1105, -1, "", 1);// 131
			AddComplexComponent( (BaseAddon) this, 1955, 0, 3, 5, 1105, -1, "", 1);// 132
			AddComplexComponent( (BaseAddon) this, 1955, 1, 0, 5, 1105, -1, "", 1);// 133
			AddComplexComponent( (BaseAddon) this, 1955, 1, 1, 5, 1105, -1, "", 1);// 134
			AddComplexComponent( (BaseAddon) this, 1955, 1, 2, 5, 1105, -1, "", 1);// 135
			AddComplexComponent( (BaseAddon) this, 1955, 1, 3, 5, 1105, -1, "", 1);// 136
			AddComplexComponent( (BaseAddon) this, 1955, 2, 0, 5, 1105, -1, "", 1);// 137
			AddComplexComponent( (BaseAddon) this, 1955, 2, 1, 5, 1105, -1, "", 1);// 138
			AddComplexComponent( (BaseAddon) this, 1955, 2, 2, 5, 1105, -1, "", 1);// 139
			AddComplexComponent( (BaseAddon) this, 1955, 2, 3, 5, 1105, -1, "", 1);// 140
			AddComplexComponent( (BaseAddon) this, 1955, 3, 0, 5, 1105, -1, "", 1);// 141
			AddComplexComponent( (BaseAddon) this, 1955, 3, 1, 5, 1105, -1, "", 1);// 142
			AddComplexComponent( (BaseAddon) this, 1955, 3, 2, 5, 1105, -1, "", 1);// 143
			AddComplexComponent( (BaseAddon) this, 1955, 3, 3, 5, 1105, -1, "", 1);// 144
			AddComplexComponent( (BaseAddon) this, 1955, 4, 0, 5, 1105, -1, "", 1);// 145
			AddComplexComponent( (BaseAddon) this, 1955, 4, 1, 5, 1105, -1, "", 1);// 146
			AddComplexComponent( (BaseAddon) this, 1955, 4, 2, 5, 1105, -1, "", 1);// 147
			AddComplexComponent( (BaseAddon) this, 1955, 4, 3, 5, 1105, -1, "", 1);// 148
			AddComplexComponent( (BaseAddon) this, 1955, 5, 0, 5, 1105, -1, "", 1);// 149
			AddComplexComponent( (BaseAddon) this, 1955, 5, 1, 5, 1105, -1, "", 1);// 150
			AddComplexComponent( (BaseAddon) this, 1955, 5, 2, 5, 1105, -1, "", 1);// 151
			AddComplexComponent( (BaseAddon) this, 1955, 5, 3, 5, 1105, -1, "", 1);// 152
			AddComplexComponent( (BaseAddon) this, 1955, -2, 0, 10, 1105, -1, "", 1);// 153
			AddComplexComponent( (BaseAddon) this, 1955, -2, 1, 10, 1105, -1, "", 1);// 154
			AddComplexComponent( (BaseAddon) this, 1955, -2, 2, 10, 1105, -1, "", 1);// 155
			AddComplexComponent( (BaseAddon) this, 1955, -2, 3, 10, 1105, -1, "", 1);// 156
			AddComplexComponent( (BaseAddon) this, 1955, -1, 0, 10, 1105, -1, "", 1);// 157
			AddComplexComponent( (BaseAddon) this, 1955, -1, 1, 10, 1105, -1, "", 1);// 158
			AddComplexComponent( (BaseAddon) this, 1955, -1, 2, 10, 1105, -1, "", 1);// 159
			AddComplexComponent( (BaseAddon) this, 1955, -1, 3, 10, 1105, -1, "", 1);// 160
			AddComplexComponent( (BaseAddon) this, 1955, 0, 0, 10, 1105, -1, "", 1);// 161
			AddComplexComponent( (BaseAddon) this, 1955, 0, 1, 10, 1105, -1, "", 1);// 162
			AddComplexComponent( (BaseAddon) this, 1955, 0, 2, 10, 1105, -1, "", 1);// 163
			AddComplexComponent( (BaseAddon) this, 1955, 0, 3, 10, 1105, -1, "", 1);// 164
			AddComplexComponent( (BaseAddon) this, 1955, 1, 0, 10, 1105, -1, "", 1);// 165
			AddComplexComponent( (BaseAddon) this, 1955, 1, 1, 10, 1105, -1, "", 1);// 166
			AddComplexComponent( (BaseAddon) this, 1955, 1, 2, 10, 1105, -1, "", 1);// 167
			AddComplexComponent( (BaseAddon) this, 1955, 1, 3, 10, 1105, -1, "", 1);// 168
			AddComplexComponent( (BaseAddon) this, 1955, 2, 0, 10, 1105, -1, "", 1);// 169
			AddComplexComponent( (BaseAddon) this, 1955, 2, 1, 10, 1105, -1, "", 1);// 170
			AddComplexComponent( (BaseAddon) this, 1955, 2, 2, 10, 1105, -1, "", 1);// 171
			AddComplexComponent( (BaseAddon) this, 1955, 2, 3, 10, 1105, -1, "", 1);// 172
			AddComplexComponent( (BaseAddon) this, 1955, 3, 0, 10, 1105, -1, "", 1);// 173
			AddComplexComponent( (BaseAddon) this, 1955, 3, 1, 10, 1105, -1, "", 1);// 174
			AddComplexComponent( (BaseAddon) this, 1955, 3, 2, 10, 1105, -1, "", 1);// 175
			AddComplexComponent( (BaseAddon) this, 1955, 3, 3, 10, 1105, -1, "", 1);// 176
			AddComplexComponent( (BaseAddon) this, 1955, 4, 0, 10, 1105, -1, "", 1);// 177
			AddComplexComponent( (BaseAddon) this, 1955, 4, 1, 10, 1105, -1, "", 1);// 178
			AddComplexComponent( (BaseAddon) this, 1955, 4, 2, 10, 1105, -1, "", 1);// 179
			AddComplexComponent( (BaseAddon) this, 1955, 4, 3, 10, 1105, -1, "", 1);// 180
			AddComplexComponent( (BaseAddon) this, 1955, 5, 0, 10, 1105, -1, "", 1);// 181
			AddComplexComponent( (BaseAddon) this, 1955, 5, 1, 10, 1105, -1, "", 1);// 182
			AddComplexComponent( (BaseAddon) this, 1955, 5, 2, 10, 1105, -1, "", 1);// 183
			AddComplexComponent( (BaseAddon) this, 1955, 5, 3, 10, 1105, -1, "", 1);// 184
			AddComplexComponent( (BaseAddon) this, 1955, -2, 0, 15, 1105, -1, "", 1);// 185
			AddComplexComponent( (BaseAddon) this, 1955, -2, 1, 15, 1105, -1, "", 1);// 186
			AddComplexComponent( (BaseAddon) this, 1955, -2, 2, 15, 1105, -1, "", 1);// 187
			AddComplexComponent( (BaseAddon) this, 1955, -2, 3, 15, 1105, -1, "", 1);// 188
			AddComplexComponent( (BaseAddon) this, 1955, -1, 0, 15, 1105, -1, "", 1);// 189
			AddComplexComponent( (BaseAddon) this, 1955, -1, 1, 15, 1105, -1, "", 1);// 190
			AddComplexComponent( (BaseAddon) this, 1955, -1, 2, 15, 1105, -1, "", 1);// 191
			AddComplexComponent( (BaseAddon) this, 1955, -1, 3, 15, 1105, -1, "", 1);// 192
			AddComplexComponent( (BaseAddon) this, 1955, 0, 0, 15, 1105, -1, "", 1);// 193
			AddComplexComponent( (BaseAddon) this, 1955, 0, 1, 15, 1105, -1, "", 1);// 194
			AddComplexComponent( (BaseAddon) this, 1955, 0, 2, 15, 1105, -1, "", 1);// 195
			AddComplexComponent( (BaseAddon) this, 1955, 0, 3, 15, 1105, -1, "", 1);// 196
			AddComplexComponent( (BaseAddon) this, 1955, 1, 0, 15, 1105, -1, "", 1);// 197
			AddComplexComponent( (BaseAddon) this, 1955, 1, 1, 15, 1105, -1, "", 1);// 198
			AddComplexComponent( (BaseAddon) this, 1955, 1, 2, 15, 1105, -1, "", 1);// 199
			AddComplexComponent( (BaseAddon) this, 1955, 1, 3, 15, 1105, -1, "", 1);// 200
			AddComplexComponent( (BaseAddon) this, 1955, 2, 0, 15, 1105, -1, "", 1);// 201
			AddComplexComponent( (BaseAddon) this, 1955, 2, 1, 15, 1105, -1, "", 1);// 202
			AddComplexComponent( (BaseAddon) this, 1955, 2, 2, 15, 1105, -1, "", 1);// 203
			AddComplexComponent( (BaseAddon) this, 1955, 2, 3, 15, 1105, -1, "", 1);// 204
			AddComplexComponent( (BaseAddon) this, 1955, 3, 0, 15, 1105, -1, "", 1);// 205
			AddComplexComponent( (BaseAddon) this, 1955, 3, 1, 15, 1105, -1, "", 1);// 206
			AddComplexComponent( (BaseAddon) this, 1955, 3, 2, 15, 1105, -1, "", 1);// 207
			AddComplexComponent( (BaseAddon) this, 1955, 3, 3, 15, 1105, -1, "", 1);// 208
			AddComplexComponent( (BaseAddon) this, 1955, 4, 0, 15, 1105, -1, "", 1);// 209
			AddComplexComponent( (BaseAddon) this, 1955, 4, 1, 15, 1105, -1, "", 1);// 210
			AddComplexComponent( (BaseAddon) this, 1955, 4, 2, 15, 1105, -1, "", 1);// 211
			AddComplexComponent( (BaseAddon) this, 1955, 4, 3, 15, 1105, -1, "", 1);// 212
			AddComplexComponent( (BaseAddon) this, 1955, 5, 0, 15, 1105, -1, "", 1);// 213
			AddComplexComponent( (BaseAddon) this, 1955, 5, 1, 15, 1105, -1, "", 1);// 214
			AddComplexComponent( (BaseAddon) this, 1955, 5, 2, 15, 1105, -1, "", 1);// 215
			AddComplexComponent( (BaseAddon) this, 1955, 5, 3, 15, 1105, -1, "", 1);// 216
			AddComplexComponent( (BaseAddon) this, 1955, -2, 0, 20, 1105, -1, "", 1);// 217
			AddComplexComponent( (BaseAddon) this, 1955, -2, 1, 20, 1105, -1, "", 1);// 218
			AddComplexComponent( (BaseAddon) this, 1955, -2, 2, 20, 1105, -1, "", 1);// 219
			AddComplexComponent( (BaseAddon) this, 1955, -2, 3, 20, 1105, -1, "", 1);// 220
			AddComplexComponent( (BaseAddon) this, 1955, -1, 0, 20, 1105, -1, "", 1);// 221
			AddComplexComponent( (BaseAddon) this, 1955, -1, 1, 20, 1105, -1, "", 1);// 222
			AddComplexComponent( (BaseAddon) this, 1955, -1, 2, 20, 1105, -1, "", 1);// 223
			AddComplexComponent( (BaseAddon) this, 1955, -1, 3, 20, 1105, -1, "", 1);// 224
			AddComplexComponent( (BaseAddon) this, 1955, 0, 0, 20, 1105, -1, "", 1);// 225
			AddComplexComponent( (BaseAddon) this, 1955, 0, 1, 20, 1105, -1, "", 1);// 226
			AddComplexComponent( (BaseAddon) this, 1955, 0, 2, 20, 1105, -1, "", 1);// 227
			AddComplexComponent( (BaseAddon) this, 1955, 0, 3, 20, 1105, -1, "", 1);// 228
			AddComplexComponent( (BaseAddon) this, 1955, 1, 0, 20, 1105, -1, "", 1);// 229
			AddComplexComponent( (BaseAddon) this, 1955, 1, 1, 20, 1105, -1, "", 1);// 230
			AddComplexComponent( (BaseAddon) this, 1955, 1, 2, 20, 1105, -1, "", 1);// 231
			AddComplexComponent( (BaseAddon) this, 1955, 1, 3, 20, 1105, -1, "", 1);// 232
			AddComplexComponent( (BaseAddon) this, 1955, 2, 0, 20, 1105, -1, "", 1);// 233
			AddComplexComponent( (BaseAddon) this, 1955, 2, 1, 20, 1105, -1, "", 1);// 234
			AddComplexComponent( (BaseAddon) this, 1955, 2, 2, 20, 1105, -1, "", 1);// 235
			AddComplexComponent( (BaseAddon) this, 1955, 2, 3, 20, 1105, -1, "", 1);// 236
			AddComplexComponent( (BaseAddon) this, 1955, 3, 0, 20, 1105, -1, "", 1);// 237
			AddComplexComponent( (BaseAddon) this, 1955, 3, 1, 20, 1105, -1, "", 1);// 238
			AddComplexComponent( (BaseAddon) this, 1955, 3, 2, 20, 1105, -1, "", 1);// 239
			AddComplexComponent( (BaseAddon) this, 1955, 3, 3, 20, 1105, -1, "", 1);// 240
			AddComplexComponent( (BaseAddon) this, 1955, 4, 0, 20, 1105, -1, "", 1);// 241
			AddComplexComponent( (BaseAddon) this, 1955, 4, 1, 20, 1105, -1, "", 1);// 242
			AddComplexComponent( (BaseAddon) this, 1955, 4, 2, 20, 1105, -1, "", 1);// 243
			AddComplexComponent( (BaseAddon) this, 1955, 4, 3, 20, 1105, -1, "", 1);// 244
			AddComplexComponent( (BaseAddon) this, 1955, 5, 0, 20, 1105, -1, "", 1);// 245
			AddComplexComponent( (BaseAddon) this, 1955, 5, 1, 20, 1105, -1, "", 1);// 246
			AddComplexComponent( (BaseAddon) this, 1955, 5, 2, 20, 1105, -1, "", 1);// 247
			AddComplexComponent( (BaseAddon) this, 1955, 5, 3, 20, 1105, -1, "", 1);// 248
			AddComplexComponent( (BaseAddon) this, 1957, 5, 0, 25, 1105, -1, "", 1);// 249
			AddComplexComponent( (BaseAddon) this, 1957, 5, 1, 25, 1105, -1, "", 1);// 250
			AddComplexComponent( (BaseAddon) this, 1957, 5, 2, 25, 1105, -1, "", 1);// 251
			AddComplexComponent( (BaseAddon) this, 1957, 5, 3, 25, 1105, -1, "", 1);// 252
			AddComplexComponent( (BaseAddon) this, 1955, -2, 0, 25, 1105, -1, "", 1);// 253
			AddComplexComponent( (BaseAddon) this, 1955, -2, 1, 25, 1105, -1, "", 1);// 254
			AddComplexComponent( (BaseAddon) this, 1955, -2, 2, 25, 1105, -1, "", 1);// 255
			AddComplexComponent( (BaseAddon) this, 1955, -2, 3, 25, 1105, -1, "", 1);// 256
			AddComplexComponent( (BaseAddon) this, 1955, -1, 0, 25, 1105, -1, "", 1);// 257
			AddComplexComponent( (BaseAddon) this, 1955, -1, 1, 25, 1105, -1, "", 1);// 258
			AddComplexComponent( (BaseAddon) this, 1955, -1, 2, 25, 1105, -1, "", 1);// 259
			AddComplexComponent( (BaseAddon) this, 1955, -1, 3, 25, 1105, -1, "", 1);// 260
			AddComplexComponent( (BaseAddon) this, 1955, 0, 0, 25, 1105, -1, "", 1);// 261
			AddComplexComponent( (BaseAddon) this, 1955, 0, 1, 25, 1105, -1, "", 1);// 262
			AddComplexComponent( (BaseAddon) this, 1955, 0, 2, 25, 1105, -1, "", 1);// 263
			AddComplexComponent( (BaseAddon) this, 1955, 0, 3, 25, 1105, -1, "", 1);// 264
			AddComplexComponent( (BaseAddon) this, 1955, 1, 0, 25, 1105, -1, "", 1);// 265
			AddComplexComponent( (BaseAddon) this, 1955, 1, 1, 25, 1105, -1, "", 1);// 266
			AddComplexComponent( (BaseAddon) this, 1955, 1, 2, 25, 1105, -1, "", 1);// 267
			AddComplexComponent( (BaseAddon) this, 1955, 1, 3, 25, 1105, -1, "", 1);// 268
			AddComplexComponent( (BaseAddon) this, 1955, 2, 0, 25, 1105, -1, "", 1);// 269
			AddComplexComponent( (BaseAddon) this, 1955, 2, 1, 25, 1105, -1, "", 1);// 270
			AddComplexComponent( (BaseAddon) this, 1955, 2, 2, 25, 1105, -1, "", 1);// 271
			AddComplexComponent( (BaseAddon) this, 1955, 2, 3, 25, 1105, -1, "", 1);// 272
			AddComplexComponent( (BaseAddon) this, 1955, 3, 0, 25, 1105, -1, "", 1);// 273
			AddComplexComponent( (BaseAddon) this, 1955, 3, 1, 25, 1105, -1, "", 1);// 274
			AddComplexComponent( (BaseAddon) this, 1955, 3, 2, 25, 1105, -1, "", 1);// 275
			AddComplexComponent( (BaseAddon) this, 1955, 3, 3, 25, 1105, -1, "", 1);// 276
			AddComplexComponent( (BaseAddon) this, 1955, 4, 0, 25, 1105, -1, "", 1);// 277
			AddComplexComponent( (BaseAddon) this, 1955, 4, 1, 25, 1105, -1, "", 1);// 278
			AddComplexComponent( (BaseAddon) this, 1955, 4, 2, 25, 1105, -1, "", 1);// 279
			AddComplexComponent( (BaseAddon) this, 1955, 4, 3, 25, 1105, -1, "", 1);// 280
			AddComplexComponent( (BaseAddon) this, 577, -2, 4, 0, 2051, -1, "", 1);// 281
			AddComplexComponent( (BaseAddon) this, 577, -1, 4, 0, 2051, -1, "", 1);// 282
			AddComplexComponent( (BaseAddon) this, 577, 0, 4, 0, 2051, -1, "", 1);// 283
			AddComplexComponent( (BaseAddon) this, 577, 1, 4, 0, 2051, -1, "", 1);// 284
			AddComplexComponent( (BaseAddon) this, 577, 2, 4, 0, 2051, -1, "", 1);// 285
			AddComplexComponent( (BaseAddon) this, 577, 3, 4, 0, 2051, -1, "", 1);// 286
			AddComplexComponent( (BaseAddon) this, 577, 4, 4, 0, 2051, -1, "", 1);// 287
			AddComplexComponent( (BaseAddon) this, 577, 5, 4, 0, 2051, -1, "", 1);// 288
			AddComplexComponent( (BaseAddon) this, 577, -2, 4, 22, 2051, -1, "", 1);// 289
			AddComplexComponent( (BaseAddon) this, 577, -1, 4, 22, 2051, -1, "", 1);// 290
			AddComplexComponent( (BaseAddon) this, 577, 0, 4, 22, 2051, -1, "", 1);// 291
			AddComplexComponent( (BaseAddon) this, 577, 1, 4, 22, 2051, -1, "", 1);// 292
			AddComplexComponent( (BaseAddon) this, 577, 2, 4, 22, 2051, -1, "", 1);// 293
			AddComplexComponent( (BaseAddon) this, 577, 3, 4, 22, 2051, -1, "", 1);// 294
			AddComplexComponent( (BaseAddon) this, 577, 4, 4, 22, 2051, -1, "", 1);// 295
			AddComplexComponent( (BaseAddon) this, 577, 5, 4, 22, 2051, -1, "", 1);// 296
			AddComplexComponent( (BaseAddon) this, 577, -2, -1, 22, 2051, -1, "", 1);// 297
			AddComplexComponent( (BaseAddon) this, 577, -1, -1, 22, 2051, -1, "", 1);// 298
			AddComplexComponent( (BaseAddon) this, 577, 0, -1, 22, 2051, -1, "", 1);// 299
			AddComplexComponent( (BaseAddon) this, 577, 1, -1, 22, 2051, -1, "", 1);// 300
			AddComplexComponent( (BaseAddon) this, 577, 2, -1, 22, 2051, -1, "", 1);// 301
			AddComplexComponent( (BaseAddon) this, 577, 3, -1, 22, 2051, -1, "", 1);// 302
			AddComplexComponent( (BaseAddon) this, 577, 4, -1, 22, 2051, -1, "", 1);// 303
			AddComplexComponent( (BaseAddon) this, 577, 5, -1, 22, 2051, -1, "", 1);// 304
			AddComplexComponent( (BaseAddon) this, 577, 5, -1, 0, 2051, -1, "", 1);// 305
			AddComplexComponent( (BaseAddon) this, 577, -2, -1, 43, 2051, -1, "", 1);// 306
			AddComplexComponent( (BaseAddon) this, 577, -1, -1, 44, 2051, -1, "", 1);// 307
			AddComplexComponent( (BaseAddon) this, 577, 0, -1, 44, 2051, -1, "", 1);// 308
			AddComplexComponent( (BaseAddon) this, 577, 1, -1, 44, 2051, -1, "", 1);// 309
			AddComplexComponent( (BaseAddon) this, 577, 2, -1, 44, 2051, -1, "", 1);// 310
			AddComplexComponent( (BaseAddon) this, 577, 3, -1, 44, 2051, -1, "", 1);// 311
			AddComplexComponent( (BaseAddon) this, 577, 4, -1, 44, 2051, -1, "", 1);// 312
			AddComplexComponent( (BaseAddon) this, 577, 5, -1, 44, 2051, -1, "", 1);// 313
			AddComplexComponent( (BaseAddon) this, 579, 4, 4, 0, 2051, -1, "", 1);// 314
			AddComplexComponent( (BaseAddon) this, 579, 5, 4, 0, 2051, -1, "", 1);// 315
			AddComplexComponent( (BaseAddon) this, 579, 5, 4, 13, 2051, -1, "", 1);// 316
			AddComplexComponent( (BaseAddon) this, 586, 5, 4, 44, 2051, -1, "", 1);// 317
			AddComplexComponent( (BaseAddon) this, 584, 5, 0, 44, 2051, -1, "", 1);// 318
			AddComplexComponent( (BaseAddon) this, 584, 5, 1, 44, 2051, -1, "", 1);// 319
			AddComplexComponent( (BaseAddon) this, 584, 5, 2, 44, 2051, -1, "", 1);// 320
			AddComplexComponent( (BaseAddon) this, 584, 5, 3, 44, 2051, -1, "", 1);// 321
			AddComplexComponent( (BaseAddon) this, 577, -2, 4, 40, 2051, -1, "", 1);// 322
			AddComplexComponent( (BaseAddon) this, 577, -1, 4, 44, 2051, -1, "", 1);// 323
			AddComplexComponent( (BaseAddon) this, 577, 0, 4, 44, 2051, -1, "", 1);// 324
			AddComplexComponent( (BaseAddon) this, 577, 1, 4, 44, 2051, -1, "", 1);// 325
			AddComplexComponent( (BaseAddon) this, 577, 2, 4, 44, 2051, -1, "", 1);// 326
			AddComplexComponent( (BaseAddon) this, 577, 3, 4, 44, 2051, -1, "", 1);// 327
			AddComplexComponent( (BaseAddon) this, 577, 4, 4, 44, 2051, -1, "", 1);// 328
			AddComplexComponent( (BaseAddon) this, 577, 5, 4, 44, 2051, -1, "", 1);// 329
			AddComplexComponent( (BaseAddon) this, 7977, 6, -4, 0, 0, -1, "Corridor_Has_Non_Lethal_but_powerful_Dart_traps", 1);// 337
			AddComplexComponent( (BaseAddon) this, 4825, 3, 0, 30, 2053, -1, "", 1);// 343
			AddComplexComponent( (BaseAddon) this, 4825, 0, 0, 30, 2052, -1, "", 1);// 344
		}

		public SV_Corridor_WestAddon( Serial serial ) : base( serial )
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

	public class SV_Corridor_WestAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SV_Corridor_WestAddon();
			}
		}

		[Constructable]
		public SV_Corridor_WestAddonDeed()
		{
			Name = "Sith Valley Corridor West";
		}

		public SV_Corridor_WestAddonDeed( Serial serial ) : base( serial )
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