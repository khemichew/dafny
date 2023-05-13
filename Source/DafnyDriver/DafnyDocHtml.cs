using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Text;

namespace Microsoft.Dafny;

class DafnyDocHtml {

  public static readonly string eol = "\n";
  public static readonly string br = "<br>";
  public static readonly string mdash = " &mdash; ";
  public static readonly string space4 = "&nbsp;&nbsp;&nbsp;&nbsp;";

  public static string HtmlStart(string title, string script = "") {
    return
      @"
<!doctype html>
<html lang=""en"">
<head>
<meta charset=""utf-8"">
<meta name=""viewport"" content=""width=1000px, initial-scale=1"">
<title>"

      + title +

@"</title>
<link rel=""icon"" type=""image/png"" href=""dafny-favicon.png"">
<meta name=""description"" content=""Documentation for Dafny code produced by dafnydoc"">
<meta name=""author"" content=""dafnydoc"">
<link rel=""stylesheet"" href=""styles.css""/>
"

+ script +

@"</head>
";
  }

  public static string ScriptStart() {
    return
@"<script type=""text/javascript"">
  window.onload = function() {
";
  }

  public static string ScriptEntry(string id) {
    return
@"
    document.getElementById(""{id}"").onclick = function() {
      document.getElementById(""rightside"").innerHTML = '<iframe id=""frame"" width=""100%"" height=""1000"" style=""border:none; scrolling:no;"" src=""{id}.html""></iframe>';
      return false;
    }
".Replace("{id}", id);
  }
  // TODO: The CSS for 'frame' does not seem to work. Setting height ot 100% makes the frame have a scrollbar and a small vertical height

  public static string ScriptEnd() {
    return
@"
  }
</script>
";
  }

  public static string BodyStart() {
    return "<body>\n";
  }

  public static string BodyAndHtmlEnd() {
    return "</body>\n</html>\n";
  }

  public static string MainStart(string label = "rightside") {
    return $"<div id=\"{label}\" class=\"{label}\">\n";
  }

  public static string MainEnd() {
    return "</div>\n";
  }


  public static string SideBar(string text) {
    return "<div class=\"sidenav\">\n"
    + text +
    "</div>\n";
  }

  public static string Indent(string text) {
    return $"<p style=\"margin-left: 25px;\">{text}</p>";
  }

  public static string Spaces(int n) {
    return new StringBuilder(6 * n).Insert(0, "&nbsp;", n).ToString();
  }

  public static string Link(string fullname, string text) {
    return $"<a href=\"{LinkTarget(fullname)}\">{text}</a>";
  }

  // Encodes a fully qualified Dafny name as a file name. 
  // Dafny names are case-sensitive; filenames are not necessarily case-sensitive.
  public static string LinkTarget(string fullname) {
    return fullname + ".html"; // TODO - needs encoding for case
  }

  public static string Heading1(string text) {
    return "<div class=\"topheading\">\n<h1>" + text + "</h1>\n</div>";
  }

  public static string Heading2(string text) {
    return "<div>\n<h2>" + text + "</h2>\n</div>";
  }

  public static string Heading3(string text) {
    return "<div>\n<h3>" + text + "</h3>\n</div>";
  }

  // Used in an h1 heading, but is a lot smaller
  public static string Smaller(string text) {
    return $"<font size=\"-1\">{text}</font>";
  }
  public static string Bold(string text) {
    return $"<b>{text}</b>";
  }

  public static string Size(string text, string value) {
    return $"<span style=\"font-size:{value};\">{text}</span>";
  }

  public static string Italics(string text) {
    return $"<i>{text}</i>";
  }

  public static string Code(string text) {
    return $"<span class=\"code\">{text}</span>";
  }
  public static string Keyword(string text) {
    return Bold(text);
  }

  public static string TableStart() {
    return "<table>";
  }

  public static string Row() {
    return $"<tr></tr>";
  }

  public static string Row(string s1) {
    return $"<tr><td>{s1}</td></tr>";
  }


  public static string Row(string s1, string s2) {
    return $"<tr><td>{s1}</td><td>{s2}</td></tr>";
  }

  public static string Row(string s1, string s2, string s3) {
    return $"<tr><td>{s1}</td><td>{s2}</td><td>{s3}</td></tr>";
  }

  public static string Row(string s1, string s2, string s3, string s4) {
    return $"<tr><td>{s1}</td><td>{s2}</td><td>{s3}</td><td>{s4}</td></tr>";
  }

  public static string Row(string s1, string s2, string s3, string s4, string s5) {
    return $"<tr><td>{s1}</td><td>{s2}</td><td>{s3}</td><td>{s4}</td><td>{s5}</td></tr>";
  }

  public static string Row(string s1, string s2, string s3, string s4, string s5, string s6) {
    return $"<tr><td>{s1}</td><td>{s2}</td><td>{s3}</td><td>{s4}</td><td>{s5}</td><td>{s6}</td></tr>";
  }

  public static String TableEnd() {
    return "</table>";
  }

  public static String ListStart() {
    return "<ul>";
  }

  public static String ListItem(String text) {
    return "<li>" + text + "</li>";
  }

  public static String ListEnd() {
    return "</ul>";
  }

  public static String Anchor(string name) {
    return $"<a id=\"{name}\"/>";
  }

  public static String LinkToAnchor(string name, string text) {
    return $"<a href=\"#{name}\">{text}</a>";
  }

  public static String RuleWithText(String text) {
    return $"<div style=\"width: 100%; height: 10px; border-bottom: 1px solid black; text-align: center\"><span style=\"font-size: 20px; background-color: #F3F5F6; padding: 0 10px;\">{text}</span></div><br>";
  }

  public static string LocalHeaderSize = "24px";

  public static readonly string Style =
  @"

.topheading {
  width: 100%;
  height: 50px;
  left: 0;
}

.rightside {
  top: 50px; /* Same as the height of topheading */
  padding-top: 0;
  margin-top: 20px;
  margin-left: 300px; /* Same as the width of the sidenav */
  height: 100%;
  overflow-y: hidden;
}

.sidenav {
  height: 100%;
  width: 300px;
  position: fixed;
  z-index: 1;
  top: 50px; /* Same as the height of topheading */
  left: 0;
  background-color: #ffffff;
  overflow-x: hidden;
  padding-top: 30px;
  margin-top: 20px;
  margin-left: 6px;
}

.sidenav a {
  padding: 6px 8px 6px 16px;
  text-decoration: none;
  font-size: 16px;
}

.sidenav a:hover {
  color: #0000ff;
}


@media screen and (max-height: 450px) {
  .sidenav {padding-top: 15px;}
  .sidenav a {font-size: 18px;}
}

body {
  background-color: white;
  font-family: 'Arial', sanserif;
}

h1 {
  color: black;
  font-weight: bold;
  text-align: center;
}
h2 {
  color: black;
  font-weight: bold;
  text-align: left;
}
h3 {
  color: black;
  text-align: left;
}

frame {
  width: 100%;
  height: 100%;
  border: none;
  background-color: #ffffa0;
}

p {
  font-size: 16px;
}

span.doctext {
   font-family: 'Arial';
}

span.code {
   font-family: 'Courier New', monospace;
}
";

}