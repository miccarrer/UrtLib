//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /home/michael/Repos/UrtLib/MapLib/Parser/Map.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419


	#pragma warning disable 3021
    using System.Globalization;
    using MapLib;
    using MapLib.Elements;
    using MapLib.Geometry;

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public partial class MapLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		PATCHDEF2=1, QUOTE=2, LROUNDBRACKET=3, RROUNDBRACKET=4, LCURLYBRACKET=5, 
		RCURLYBRACKET=6, KEYVALUE=7, PATH=8, EXP=9, DECIMAL=10, INT=11, WS=12, 
		NL=13, WORD=14, COMMENT=15;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"PATCHDEF2", "QUOTE", "LROUNDBRACKET", "RROUNDBRACKET", "LCURLYBRACKET", 
		"RCURLYBRACKET", "KEYVALUE", "PATH", "EXP", "DECIMAL", "INT", "WS", "NL", 
		"WORD", "LETTER", "SIGN", "DIGIT", "DOT", "COMMENT"
	};


	public MapLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public MapLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'patchDef2'", "'\"'", "'('", "')'", "'{'", "'}'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "PATCHDEF2", "QUOTE", "LROUNDBRACKET", "RROUNDBRACKET", "LCURLYBRACKET", 
		"RCURLYBRACKET", "KEYVALUE", "PATH", "EXP", "DECIMAL", "INT", "WS", "NL", 
		"WORD", "COMMENT"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Map.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static MapLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	public override void Action(RuleContext _localctx, int ruleIndex, int actionIndex) {
		switch (ruleIndex) {
		case 18 : COMMENT_action(_localctx, actionIndex); break;
		}
	}
	private void COMMENT_action(RuleContext _localctx, int actionIndex) {
		switch (actionIndex) {
		case 0: Skip(); break;
		}
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x11', '\x9C', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\a', '\b', 
		'@', '\n', '\b', '\f', '\b', '\xE', '\b', '\x43', '\v', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x6', '\t', 'J', 
		'\n', '\t', '\r', '\t', '\xE', '\t', 'K', '\x3', '\t', '\x3', '\t', '\x3', 
		'\t', '\x3', '\t', '\x5', '\t', 'R', '\n', '\t', '\x3', '\n', '\x3', '\n', 
		'\x3', '\n', '\x3', '\n', '\x3', '\v', '\x5', '\v', 'Y', '\n', '\v', '\x3', 
		'\v', '\a', '\v', '\\', '\n', '\v', '\f', '\v', '\xE', '\v', '_', '\v', 
		'\v', '\x3', '\v', '\x3', '\v', '\x6', '\v', '\x63', '\n', '\v', '\r', 
		'\v', '\xE', '\v', '\x64', '\x3', '\f', '\x5', '\f', 'h', '\n', '\f', 
		'\x3', '\f', '\x6', '\f', 'k', '\n', '\f', '\r', '\f', '\xE', '\f', 'l', 
		'\x3', '\r', '\x6', '\r', 'p', '\n', '\r', '\r', '\r', '\xE', '\r', 'q', 
		'\x3', '\xE', '\x6', '\xE', 'u', '\n', '\xE', '\r', '\xE', '\xE', '\xE', 
		'v', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x6', '\xF', 
		'}', '\n', '\xF', '\r', '\xF', '\xE', '\xF', '~', '\x3', '\x10', '\x3', 
		'\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x12', '\x3', '\x12', '\x3', 
		'\x13', '\x3', '\x13', '\x3', '\x14', '\x5', '\x14', '\x8A', '\n', '\x14', 
		'\x3', '\x14', '\a', '\x14', '\x8D', '\n', '\x14', '\f', '\x14', '\xE', 
		'\x14', '\x90', '\v', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', 
		'\x3', '\x14', '\a', '\x14', '\x96', '\n', '\x14', '\f', '\x14', '\xE', 
		'\x14', '\x99', '\v', '\x14', '\x3', '\x14', '\x3', '\x14', '\x2', '\x2', 
		'\x15', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', 
		'\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', 
		'\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x2', '!', 
		'\x2', '#', '\x2', '%', '\x2', '\'', '\x11', '\x3', '\x2', '\b', '\x3', 
		'\x2', '$', '$', '\x4', '\x2', '\v', '\v', '\"', '\"', '\x4', '\x2', '\f', 
		'\f', '\xF', '\xF', '\x5', '\x2', '-', '-', '/', '/', '\x61', '\x61', 
		'\x4', '\x2', '\x43', '\\', '\x63', '|', '\x4', '\x2', '-', '-', '/', 
		'/', '\x2', '\xA8', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x3', ')', 
		'\x3', '\x2', '\x2', '\x2', '\x5', '\x33', '\x3', '\x2', '\x2', '\x2', 
		'\a', '\x35', '\x3', '\x2', '\x2', '\x2', '\t', '\x37', '\x3', '\x2', 
		'\x2', '\x2', '\v', '\x39', '\x3', '\x2', '\x2', '\x2', '\r', ';', '\x3', 
		'\x2', '\x2', '\x2', '\xF', '=', '\x3', '\x2', '\x2', '\x2', '\x11', 'I', 
		'\x3', '\x2', '\x2', '\x2', '\x13', 'S', '\x3', '\x2', '\x2', '\x2', '\x15', 
		'X', '\x3', '\x2', '\x2', '\x2', '\x17', 'g', '\x3', '\x2', '\x2', '\x2', 
		'\x19', 'o', '\x3', '\x2', '\x2', '\x2', '\x1B', 't', '\x3', '\x2', '\x2', 
		'\x2', '\x1D', '|', '\x3', '\x2', '\x2', '\x2', '\x1F', '\x80', '\x3', 
		'\x2', '\x2', '\x2', '!', '\x82', '\x3', '\x2', '\x2', '\x2', '#', '\x84', 
		'\x3', '\x2', '\x2', '\x2', '%', '\x86', '\x3', '\x2', '\x2', '\x2', '\'', 
		'\x89', '\x3', '\x2', '\x2', '\x2', ')', '*', '\a', 'r', '\x2', '\x2', 
		'*', '+', '\a', '\x63', '\x2', '\x2', '+', ',', '\a', 'v', '\x2', '\x2', 
		',', '-', '\a', '\x65', '\x2', '\x2', '-', '.', '\a', 'j', '\x2', '\x2', 
		'.', '/', '\a', '\x46', '\x2', '\x2', '/', '\x30', '\a', 'g', '\x2', '\x2', 
		'\x30', '\x31', '\a', 'h', '\x2', '\x2', '\x31', '\x32', '\a', '\x34', 
		'\x2', '\x2', '\x32', '\x4', '\x3', '\x2', '\x2', '\x2', '\x33', '\x34', 
		'\a', '$', '\x2', '\x2', '\x34', '\x6', '\x3', '\x2', '\x2', '\x2', '\x35', 
		'\x36', '\a', '*', '\x2', '\x2', '\x36', '\b', '\x3', '\x2', '\x2', '\x2', 
		'\x37', '\x38', '\a', '+', '\x2', '\x2', '\x38', '\n', '\x3', '\x2', '\x2', 
		'\x2', '\x39', ':', '\a', '}', '\x2', '\x2', ':', '\f', '\x3', '\x2', 
		'\x2', '\x2', ';', '<', '\a', '\x7F', '\x2', '\x2', '<', '\xE', '\x3', 
		'\x2', '\x2', '\x2', '=', '\x41', '\a', '$', '\x2', '\x2', '>', '@', '\n', 
		'\x2', '\x2', '\x2', '?', '>', '\x3', '\x2', '\x2', '\x2', '@', '\x43', 
		'\x3', '\x2', '\x2', '\x2', '\x41', '?', '\x3', '\x2', '\x2', '\x2', '\x41', 
		'\x42', '\x3', '\x2', '\x2', '\x2', '\x42', '\x44', '\x3', '\x2', '\x2', 
		'\x2', '\x43', '\x41', '\x3', '\x2', '\x2', '\x2', '\x44', '\x45', '\a', 
		'$', '\x2', '\x2', '\x45', '\x10', '\x3', '\x2', '\x2', '\x2', '\x46', 
		'G', '\x5', '\x1D', '\xF', '\x2', 'G', 'H', '\a', '\x31', '\x2', '\x2', 
		'H', 'J', '\x3', '\x2', '\x2', '\x2', 'I', '\x46', '\x3', '\x2', '\x2', 
		'\x2', 'J', 'K', '\x3', '\x2', '\x2', '\x2', 'K', 'I', '\x3', '\x2', '\x2', 
		'\x2', 'K', 'L', '\x3', '\x2', '\x2', '\x2', 'L', 'M', '\x3', '\x2', '\x2', 
		'\x2', 'M', 'Q', '\x5', '\x1D', '\xF', '\x2', 'N', 'O', '\x5', '%', '\x13', 
		'\x2', 'O', 'P', '\x5', '\x1D', '\xF', '\x2', 'P', 'R', '\x3', '\x2', 
		'\x2', '\x2', 'Q', 'N', '\x3', '\x2', '\x2', '\x2', 'Q', 'R', '\x3', '\x2', 
		'\x2', '\x2', 'R', '\x12', '\x3', '\x2', '\x2', '\x2', 'S', 'T', '\x5', 
		'\x15', '\v', '\x2', 'T', 'U', '\a', 'G', '\x2', '\x2', 'U', 'V', '\x5', 
		'\x17', '\f', '\x2', 'V', '\x14', '\x3', '\x2', '\x2', '\x2', 'W', 'Y', 
		'\x5', '!', '\x11', '\x2', 'X', 'W', '\x3', '\x2', '\x2', '\x2', 'X', 
		'Y', '\x3', '\x2', '\x2', '\x2', 'Y', ']', '\x3', '\x2', '\x2', '\x2', 
		'Z', '\\', '\x5', '#', '\x12', '\x2', '[', 'Z', '\x3', '\x2', '\x2', '\x2', 
		'\\', '_', '\x3', '\x2', '\x2', '\x2', ']', '[', '\x3', '\x2', '\x2', 
		'\x2', ']', '^', '\x3', '\x2', '\x2', '\x2', '^', '`', '\x3', '\x2', '\x2', 
		'\x2', '_', ']', '\x3', '\x2', '\x2', '\x2', '`', '\x62', '\x5', '%', 
		'\x13', '\x2', '\x61', '\x63', '\x5', '#', '\x12', '\x2', '\x62', '\x61', 
		'\x3', '\x2', '\x2', '\x2', '\x63', '\x64', '\x3', '\x2', '\x2', '\x2', 
		'\x64', '\x62', '\x3', '\x2', '\x2', '\x2', '\x64', '\x65', '\x3', '\x2', 
		'\x2', '\x2', '\x65', '\x16', '\x3', '\x2', '\x2', '\x2', '\x66', 'h', 
		'\x5', '!', '\x11', '\x2', 'g', '\x66', '\x3', '\x2', '\x2', '\x2', 'g', 
		'h', '\x3', '\x2', '\x2', '\x2', 'h', 'j', '\x3', '\x2', '\x2', '\x2', 
		'i', 'k', '\x5', '#', '\x12', '\x2', 'j', 'i', '\x3', '\x2', '\x2', '\x2', 
		'k', 'l', '\x3', '\x2', '\x2', '\x2', 'l', 'j', '\x3', '\x2', '\x2', '\x2', 
		'l', 'm', '\x3', '\x2', '\x2', '\x2', 'm', '\x18', '\x3', '\x2', '\x2', 
		'\x2', 'n', 'p', '\t', '\x3', '\x2', '\x2', 'o', 'n', '\x3', '\x2', '\x2', 
		'\x2', 'p', 'q', '\x3', '\x2', '\x2', '\x2', 'q', 'o', '\x3', '\x2', '\x2', 
		'\x2', 'q', 'r', '\x3', '\x2', '\x2', '\x2', 'r', '\x1A', '\x3', '\x2', 
		'\x2', '\x2', 's', 'u', '\t', '\x4', '\x2', '\x2', 't', 's', '\x3', '\x2', 
		'\x2', '\x2', 'u', 'v', '\x3', '\x2', '\x2', '\x2', 'v', 't', '\x3', '\x2', 
		'\x2', '\x2', 'v', 'w', '\x3', '\x2', '\x2', '\x2', 'w', '\x1C', '\x3', 
		'\x2', '\x2', '\x2', 'x', '}', '\x5', '\x1F', '\x10', '\x2', 'y', '}', 
		'\x5', '#', '\x12', '\x2', 'z', '}', '\t', '\x5', '\x2', '\x2', '{', '}', 
		'\x5', '%', '\x13', '\x2', '|', 'x', '\x3', '\x2', '\x2', '\x2', '|', 
		'y', '\x3', '\x2', '\x2', '\x2', '|', 'z', '\x3', '\x2', '\x2', '\x2', 
		'|', '{', '\x3', '\x2', '\x2', '\x2', '}', '~', '\x3', '\x2', '\x2', '\x2', 
		'~', '|', '\x3', '\x2', '\x2', '\x2', '~', '\x7F', '\x3', '\x2', '\x2', 
		'\x2', '\x7F', '\x1E', '\x3', '\x2', '\x2', '\x2', '\x80', '\x81', '\t', 
		'\x6', '\x2', '\x2', '\x81', ' ', '\x3', '\x2', '\x2', '\x2', '\x82', 
		'\x83', '\t', '\a', '\x2', '\x2', '\x83', '\"', '\x3', '\x2', '\x2', '\x2', 
		'\x84', '\x85', '\x4', '\x32', ';', '\x2', '\x85', '$', '\x3', '\x2', 
		'\x2', '\x2', '\x86', '\x87', '\a', '\x30', '\x2', '\x2', '\x87', '&', 
		'\x3', '\x2', '\x2', '\x2', '\x88', '\x8A', '\x5', '\x1B', '\xE', '\x2', 
		'\x89', '\x88', '\x3', '\x2', '\x2', '\x2', '\x89', '\x8A', '\x3', '\x2', 
		'\x2', '\x2', '\x8A', '\x8E', '\x3', '\x2', '\x2', '\x2', '\x8B', '\x8D', 
		'\x5', '\x19', '\r', '\x2', '\x8C', '\x8B', '\x3', '\x2', '\x2', '\x2', 
		'\x8D', '\x90', '\x3', '\x2', '\x2', '\x2', '\x8E', '\x8C', '\x3', '\x2', 
		'\x2', '\x2', '\x8E', '\x8F', '\x3', '\x2', '\x2', '\x2', '\x8F', '\x91', 
		'\x3', '\x2', '\x2', '\x2', '\x90', '\x8E', '\x3', '\x2', '\x2', '\x2', 
		'\x91', '\x92', '\a', '\x31', '\x2', '\x2', '\x92', '\x93', '\a', '\x31', 
		'\x2', '\x2', '\x93', '\x97', '\x3', '\x2', '\x2', '\x2', '\x94', '\x96', 
		'\n', '\x4', '\x2', '\x2', '\x95', '\x94', '\x3', '\x2', '\x2', '\x2', 
		'\x96', '\x99', '\x3', '\x2', '\x2', '\x2', '\x97', '\x95', '\x3', '\x2', 
		'\x2', '\x2', '\x97', '\x98', '\x3', '\x2', '\x2', '\x2', '\x98', '\x9A', 
		'\x3', '\x2', '\x2', '\x2', '\x99', '\x97', '\x3', '\x2', '\x2', '\x2', 
		'\x9A', '\x9B', '\b', '\x14', '\x2', '\x2', '\x9B', '(', '\x3', '\x2', 
		'\x2', '\x2', '\x12', '\x2', '\x41', 'K', 'Q', 'X', ']', '\x64', 'g', 
		'l', 'q', 'v', '|', '~', '\x89', '\x8E', '\x97', '\x3', '\x3', '\x14', 
		'\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
