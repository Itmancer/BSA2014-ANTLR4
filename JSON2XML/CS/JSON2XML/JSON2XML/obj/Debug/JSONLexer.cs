//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\Practice\JSON2XML\CS\JSON2XML\JSON2XML\JSON.g4 by ANTLR 4.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace JSON2XML {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.3")]
[System.CLSCompliant(false)]
public partial class JSONLexer : Lexer {
	public const int
		T__6=1, T__5=2, T__4=3, T__3=4, T__2=5, T__1=6, T__0=7, LCURLY=8, LBRACK=9, 
		STRING=10, NUMBER=11, WS=12;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] tokenNames = {
		"'\\u0000'", "'\\u0001'", "'\\u0002'", "'\\u0003'", "'\\u0004'", "'\\u0005'", 
		"'\\u0006'", "'\\u0007'", "'\b'", "'\t'", "'\n'", "'\\u000B'", "'\f'"
	};
	public static readonly string[] ruleNames = {
		"T__6", "T__5", "T__4", "T__3", "T__2", "T__1", "T__0", "LCURLY", "LBRACK", 
		"STRING", "ESC", "UNICODE", "HEX", "NUMBER", "INT", "EXP", "WS"
	};


	public JSONLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	public override string GrammarFileName { get { return "JSON.g4"; } }

	public override string[] TokenNames { get { return tokenNames; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\xE\x84\b\x1\x4"+
		"\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b"+
		"\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4"+
		"\x10\t\x10\x4\x11\t\x11\x4\x12\t\x12\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x4\x3\x4\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6"+
		"\x3\a\x3\a\x3\b\x3\b\x3\b\x3\b\x3\b\x3\t\x3\t\x3\n\x3\n\x3\v\x3\v\x3\v"+
		"\a\v\x45\n\v\f\v\xE\vH\v\v\x3\v\x3\v\x3\f\x3\f\x3\f\x5\fO\n\f\x3\r\x3"+
		"\r\x3\r\x3\r\x3\r\x3\r\x3\xE\x3\xE\x3\xF\x5\xFZ\n\xF\x3\xF\x3\xF\x3\xF"+
		"\x3\xF\x5\xF`\n\xF\x3\xF\x5\xF\x63\n\xF\x3\xF\x3\xF\x3\xF\x3\xF\x5\xF"+
		"i\n\xF\x3\xF\x5\xFl\n\xF\x3\x10\x3\x10\x3\x10\a\x10q\n\x10\f\x10\xE\x10"+
		"t\v\x10\x5\x10v\n\x10\x3\x11\x3\x11\x5\x11z\n\x11\x3\x11\x3\x11\x3\x12"+
		"\x6\x12\x7F\n\x12\r\x12\xE\x12\x80\x3\x12\x3\x12\x2\x2\x2\x13\x3\x2\x3"+
		"\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15"+
		"\x2\f\x17\x2\x2\x19\x2\x2\x1B\x2\x2\x1D\x2\r\x1F\x2\x2!\x2\x2#\x2\xE\x3"+
		"\x2\b\x4\x2$$^^\n\x2$$\x31\x31^^\x64\x64hhppttvv\x5\x2\x32;\x43H\x63h"+
		"\x4\x2GGgg\x4\x2--//\x5\x2\v\f\xF\xF\"\"\x8B\x2\x3\x3\x2\x2\x2\x2\x5\x3"+
		"\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2"+
		"\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15"+
		"\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x3%\x3\x2\x2\x2\x5\'\x3"+
		"\x2\x2\x2\a,\x3\x2\x2\x2\t.\x3\x2\x2\x2\v\x30\x3\x2\x2\x2\r\x36\x3\x2"+
		"\x2\x2\xF\x38\x3\x2\x2\x2\x11=\x3\x2\x2\x2\x13?\x3\x2\x2\x2\x15\x41\x3"+
		"\x2\x2\x2\x17K\x3\x2\x2\x2\x19P\x3\x2\x2\x2\x1BV\x3\x2\x2\x2\x1Dk\x3\x2"+
		"\x2\x2\x1Fu\x3\x2\x2\x2!w\x3\x2\x2\x2#~\x3\x2\x2\x2%&\a_\x2\x2&\x4\x3"+
		"\x2\x2\x2\'(\ap\x2\x2()\aw\x2\x2)*\an\x2\x2*+\an\x2\x2+\x6\x3\x2\x2\x2"+
		",-\a.\x2\x2-\b\x3\x2\x2\x2./\a<\x2\x2/\n\x3\x2\x2\x2\x30\x31\ah\x2\x2"+
		"\x31\x32\a\x63\x2\x2\x32\x33\an\x2\x2\x33\x34\au\x2\x2\x34\x35\ag\x2\x2"+
		"\x35\f\x3\x2\x2\x2\x36\x37\a\x7F\x2\x2\x37\xE\x3\x2\x2\x2\x38\x39\av\x2"+
		"\x2\x39:\at\x2\x2:;\aw\x2\x2;<\ag\x2\x2<\x10\x3\x2\x2\x2=>\a}\x2\x2>\x12"+
		"\x3\x2\x2\x2?@\a]\x2\x2@\x14\x3\x2\x2\x2\x41\x46\a$\x2\x2\x42\x45\x5\x17"+
		"\f\x2\x43\x45\n\x2\x2\x2\x44\x42\x3\x2\x2\x2\x44\x43\x3\x2\x2\x2\x45H"+
		"\x3\x2\x2\x2\x46\x44\x3\x2\x2\x2\x46G\x3\x2\x2\x2GI\x3\x2\x2\x2H\x46\x3"+
		"\x2\x2\x2IJ\a$\x2\x2J\x16\x3\x2\x2\x2KN\a^\x2\x2LO\t\x3\x2\x2MO\x5\x19"+
		"\r\x2NL\x3\x2\x2\x2NM\x3\x2\x2\x2O\x18\x3\x2\x2\x2PQ\aw\x2\x2QR\x5\x1B"+
		"\xE\x2RS\x5\x1B\xE\x2ST\x5\x1B\xE\x2TU\x5\x1B\xE\x2U\x1A\x3\x2\x2\x2V"+
		"W\t\x4\x2\x2W\x1C\x3\x2\x2\x2XZ\a/\x2\x2YX\x3\x2\x2\x2YZ\x3\x2\x2\x2Z"+
		"[\x3\x2\x2\x2[\\\x5\x1F\x10\x2\\]\a\x30\x2\x2]_\x5\x1F\x10\x2^`\x5!\x11"+
		"\x2_^\x3\x2\x2\x2_`\x3\x2\x2\x2`l\x3\x2\x2\x2\x61\x63\a/\x2\x2\x62\x61"+
		"\x3\x2\x2\x2\x62\x63\x3\x2\x2\x2\x63\x64\x3\x2\x2\x2\x64\x65\x5\x1F\x10"+
		"\x2\x65\x66\x5!\x11\x2\x66l\x3\x2\x2\x2gi\a/\x2\x2hg\x3\x2\x2\x2hi\x3"+
		"\x2\x2\x2ij\x3\x2\x2\x2jl\x5\x1F\x10\x2kY\x3\x2\x2\x2k\x62\x3\x2\x2\x2"+
		"kh\x3\x2\x2\x2l\x1E\x3\x2\x2\x2mv\a\x32\x2\x2nr\x4\x33;\x2oq\x4\x32;\x2"+
		"po\x3\x2\x2\x2qt\x3\x2\x2\x2rp\x3\x2\x2\x2rs\x3\x2\x2\x2sv\x3\x2\x2\x2"+
		"tr\x3\x2\x2\x2um\x3\x2\x2\x2un\x3\x2\x2\x2v \x3\x2\x2\x2wy\t\x5\x2\x2"+
		"xz\t\x6\x2\x2yx\x3\x2\x2\x2yz\x3\x2\x2\x2z{\x3\x2\x2\x2{|\x5\x1F\x10\x2"+
		"|\"\x3\x2\x2\x2}\x7F\t\a\x2\x2~}\x3\x2\x2\x2\x7F\x80\x3\x2\x2\x2\x80~"+
		"\x3\x2\x2\x2\x80\x81\x3\x2\x2\x2\x81\x82\x3\x2\x2\x2\x82\x83\b\x12\x2"+
		"\x2\x83$\x3\x2\x2\x2\xF\x2\x44\x46NY_\x62hkruy\x80\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace JSON2XML
