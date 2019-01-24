<!DOCTYPE HTML PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml"><head>
<meta http-equiv="content-type" content="text/html; charset=UTF-8"><title>
	
  Memory-Mapped Files

</title><link href="memoryMappedFiles_elemei/d139d5bea064890c3efb4d72fedff27b.css" rel="stylesheet" type="text/css"><link rel="alternate" media="print" href="http://msdn.microsoft.com/en-us/library/dd997372%28d=printer%29.aspx"><meta name="DCS.dcsuri" content="/en-us/library/dd997372(d=lightweight,l=en-us,v=VS.100).aspx"><meta name="NormalizedUrl" content="http://msdn.microsoft.com/en-us/library/dd997372(d=lightweight,l=en-us,v=VS.100).aspx"><meta name="DCSext.ProductFamily" content="LIB_DG"><meta name="DCSext.Product" content="NDP_CLR"><meta name="DCSext.Title" content="Memory-Mapped Files"><meta name="VotingContextUrl" content="http://msdn.microsoft.com/en-us/library/dd997372(l=en-us,v=VS.100).aspx"><meta name="MN" content="D1DC116E-12:05:54 AM"><meta name="Search.ShortId" content="dd997372"><meta name="Ms.Locale" content="en-us"></head><body><div class="header"><table class="headerBar cl_lightweight_topnav_slice" border="0" cellpadding="0" cellspacing="0"><tbody><tr><td class="leftSection cl_lightweight_header_leftSection_wave leftSectionImageClusterOverride"><div class="tabContainer"><a href="http://msdn.microsoft.com/en-us/" title="Home" class=" headerTab">Home</a><a href="http://msdn.microsoft.com/en-us/library" title="Library" class="headerTabSelected cl_lightweight_selected_tab_repeatX ">Library</a><a href="http://msdn.microsoft.com/en-us/bb188199.aspx" title="Learn" class=" headerTab">Learn</a><a href="http://msdn.microsoft.com/en-us/aa570309.aspx" title="Downloads" class=" headerTab">Downloads</a><a href="http://msdn.microsoft.com/en-us/aa570318.aspx" title="Support" class=" headerTab">Support</a><a href="http://msdn.microsoft.com/en-us/aa497440.aspx" title="Community" class=" headerTab">Community</a></div></td><td class="rightSection cl_lightweight_header_rightSection_wave rightSectionImageClusterOverride"><div class="tabContainer"><a href="https://login.live.com/login.srf?wa=wsignin1.0&amp;rpsnv=11&amp;ct=1289113554&amp;rver=6.0.5276.0&amp;wp=MCLBI&amp;wlcxt=msdn%24msdn%24msdn&amp;wreply=http:%2F%2Fmsdn.microsoft.com%2Fen-us%2Flibrary%2Fdd997372.aspx&amp;lc=1033&amp;cb=&amp;id=254354" title="Sign in">Sign in </a><span class="pipe">|</span><a href="http://msdn.microsoft.com/en-us/library/preferences/locale/?returnurl=%252fen-us%252flibrary%252fdd997372.aspx" title="Magyarország - Magyar">Magyarország - Magyar </a><span class="pipe">|</span><a href="http://msdn.microsoft.com/en-us/library/preferences/experience/?returnurl=%252fen-us%252flibrary%252fdd997372.aspx" title="Preferences">Preferences</a></div></td></tr></tbody></table></div><div class="contentPlaceHolder"><div class="navigation" id="Navigation" style="width: 380px;"><div class="searchcontainer"><form id="SearchForm" action="http://social.msdn.microsoft.com/Search/en-us" method="get" style="margin: 0pt; padding: 0pt;"><div class="searchBoxContainer" style=""><table class="searchBox" border="0" cellpadding="0" cellspacing="0"><tbody><tr><td class="searchTextBoxTd"><input id="Text1" maxlength="200" class="searchTextBox" name="query" value="Search MSDN with Bing" onfocus="document.onkeydown = ''; WatermarkFocus(this, 'Search MSDN with Bing', 'searchTextBoxTrue') " onblur="document.onkeydown = Presskey;WatermarkBlur(this, 'Search MSDN with Bing', 'searchTextBox')" type="text"></td><td class="searchButtonTd"><a href="#" style="display: block; overflow: hidden; width: 19px; height: 19px; position: relative; padding: 0pt; margin: 0pt;" onclick="javascript:document.getElementById('SearchForm').submit();"><img src="memoryMappedFiles_elemei/8841a3a4fc3a5f17f74da3b076fe248a.png" class="cl_search_icon" style="position: relative;" title="Search" alt="Search"></a></td></tr></tbody></table></div></form></div><div class="navcontainer"><div class="nav"><div class="toclevel0 ancestry"><div class="clip5x9 nav_root"><img src="memoryMappedFiles_elemei/8841a3a4fc3a5f17f74da3b076fe248a.png" class="cl_nav_bullet" alt=""></div><div class="nav_div_currentroot"><a href="http://msdn.microsoft.com/en-us/library/ms123401.aspx" title="MSDN Library">MSDN Library</a></div><div class="clip5x9 nav_arrows"><img src="memoryMappedFiles_elemei/8841a3a4fc3a5f17f74da3b076fe248a.png" class="cl_nav_arrow" alt=""></div><div class="nav_div_currentroot"><a href="http://msdn.microsoft.com/en-us/library/ff361664.aspx" title=".NET Development">.NET Development</a></div><div class="clip5x9 nav_arrows"><img src="memoryMappedFiles_elemei/8841a3a4fc3a5f17f74da3b076fe248a.png" class="cl_nav_arrow" alt=""></div><div class="nav_div_currentroot"><a href="http://msdn.microsoft.com/en-us/library/w0x726c2.aspx" title=".NET Framework 4">.NET Framework 4</a></div><div class="clip5x9 nav_arrows"><img src="memoryMappedFiles_elemei/8841a3a4fc3a5f17f74da3b076fe248a.png" class="cl_nav_arrow" alt=""></div><div class="nav_div_currentroot"><a href="http://msdn.microsoft.com/en-us/library/190bkk9s.aspx" title=".NET Framework Core Development">.NET Framework Core Development</a></div><div class="clip5x9 nav_arrows"><img src="memoryMappedFiles_elemei/8841a3a4fc3a5f17f74da3b076fe248a.png" class="cl_nav_arrow" alt=""></div><div class="nav_div_currentroot"><a href="http://msdn.microsoft.com/en-us/library/ms172157.aspx" title="Development Fundamentals">Development Fundamentals</a></div><div class="clip5x9 nav_arrows"><img src="memoryMappedFiles_elemei/8841a3a4fc3a5f17f74da3b076fe248a.png" class="cl_nav_arrow" alt=""></div><div class="nav_div_currentroot"><a href="http://msdn.microsoft.com/en-us/library/k3352a4t.aspx" title="File and Stream I/O">File and Stream I/O</a></div></div><div class="clip13x9 nav_dots_current"><img src="memoryMappedFiles_elemei/8841a3a4fc3a5f17f74da3b076fe248a.png" class="cl_nav_dots" alt=""></div><div class="toclevel1 current"><a href="http://msdn.microsoft.com/en-us/library/dd997372.aspx" title="Memory-Mapped Files">Memory-Mapped Files</a></div><div class="toclevel2 children" style="border-bottom: 1px solid rgb(187, 187, 187);"></div><img src="memoryMappedFiles_elemei/030c41d9079671d09a62d8e2c1db6973.gif" alt="Separator" class="communityContentNavigationSeparator cl_lt_cc_line_top"><div class="communityContentNavigation"><div class="communityContentNavigationHeader">
      Community Content</div><div class="communityContentNavigationPost"><div class="communityContentNavigationAvatarContainer"><a class="communityContentNavigationLinkAvatar" href="#CommunityContent" title="User"><img alt="Avatar" class="cl_default_avatar" src="memoryMappedFiles_elemei/030c41d9079671d09a62d8e2c1db6973.gif"></a></div><div class="communityContentNavigationLinkAbstractAdvertisement"><ul><li>
            Add code samples and tips to enhance this topic.</li></ul></div></div><div class="communityContentNavigationMoreLink"><a href="#CommunityContent" title="More...">More...</a></div></div></div></div></div><a href="#" onclick="onIncreaseToc()" class="tocResize" id="TocResize" style="left: 380px;"><img id="ResizeImageIncrease" class="cl_nav_resize_open" src="memoryMappedFiles_elemei/8841a3a4fc3a5f17f74da3b076fe248a.png" onmousedown="onIncreaseToc()" title="Expand" alt="Expand"><img id="ResizeImageReset" class="cl_nav_resize_close" src="memoryMappedFiles_elemei/8841a3a4fc3a5f17f74da3b076fe248a.png" style="display: none;" onmousedown="onResetToc()" title="Minimize" alt="Minimize"></a><div class="content"><div class="clip117x31 logo"><a href="http://msdn.microsoft.com/en-us/library/default.aspx"><img src="memoryMappedFiles_elemei/8841a3a4fc3a5f17f74da3b076fe248a.png" class="msdn_body_logo" alt="MSDN" title="MSDN"></a></div><img class="TOC_Fade_Top cl_lw_toc_fade_top" src="memoryMappedFiles_elemei/030c41d9079671d09a62d8e2c1db6973.gif" alt=""><div class="topicContainer"><div class="topic" xmlns="http://www.w3.org/1999/xhtml"><h1 class="title">Memory-Mapped Files</h1><div class="lw_vs"><div id="curversion"><strong>
            .NET Framework 4</strong></div></div><div id="mainSection"><div id="mainBody"><p></p><div class="introduction"><p>A
 memory-mapped file contains the contents of a file in virtual memory. 
This mapping between a file and memory space enables an application, 
including multiple processes, to modify the file by reading and writing 
directly to the memory. Starting with the .NET Framework version&nbsp;4,
 you can use managed code to access memory-mapped files in the same way 
that native Windows functions access memory-mapped files, as described 
in <a href="http://go.microsoft.com/fwlink/?linkid=180801">Managing Memory-Mapped Files in Win32</a> in the MSDN Library.</p><p>There are two types of memory-mapped files:</p><ul><li><p>Persisted memory-mapped files</p><p>Persisted
 files are memory-mapped files that are associated with a source file on
 a disk. When the last process has finished working with the file, the 
data is saved to the source file on the disk. These memory-mapped files 
are suitable for working with extremely large source files. </p></li><li><p>Non-persisted memory-mapped files</p><p>Non-persisted
 files are memory-mapped files that are not associated with a file on a 
disk. When the last process has finished working with the file, the data
 is lost and the file is reclaimed by garbage collection. These files 
are suitable for creating shared memory for inter-process communications
 (IPC). </p></li></ul></div><div class="LW_CollapsibleArea_Container" xmlns=""><div class="LW_CollapsibleArea_TitleDiv"><span class="LW_CollapsibleArea_Title">Processes, Views, and Managing Memory</span><div class="LW_CollapsibleArea_HrDiv"><hr class="LW_CollapsibleArea_Hr"></div></div><a id="sectionToggle0" xmlns="http://www.w3.org/1999/xhtml"></a><p xmlns="http://www.w3.org/1999/xhtml">Memory-mapped
 files can be shared across multiple processes. Processes can map to the
 same memory-mapped file by using a common name that is assigned by the 
process that created the file. </p><p xmlns="http://www.w3.org/1999/xhtml">To
 work with a memory-mapped file, you must create a view of the entire 
memory-mapped file or a part of it. You can also create multiple views 
to the same part of the memory-mapped file, thereby creating concurrent 
memory. For two views to remain concurrent, they have to be created from
 the same memory-mapped file. </p><p xmlns="http://www.w3.org/1999/xhtml">Multiple
 views may also be necessary if the file is greater than the size of the
 application’s logical memory space available for memory mapping (2 GB 
on a 32-bit computer). </p><p xmlns="http://www.w3.org/1999/xhtml">There
 are two types of views: stream access view and random access view. Use 
stream access views for sequential access to a file; this is recommended
 for non-persisted files and IPC. Random access views are preferred for 
working with persisted files.</p><p xmlns="http://www.w3.org/1999/xhtml">Memory-mapped
 files are accessed through the operating system’s memory manager, so 
the file is automatically partitioned into a number of pages and 
accessed as needed. You do not have to handle the memory management 
yourself.</p><p xmlns="http://www.w3.org/1999/xhtml">The following 
illustration shows how multiple processes can have multiple and 
overlapping views to the same memory-mapped file at the same time. </p><div class="caption" xmlns="http://www.w3.org/1999/xhtml">Multiple and overlapped views to a memory-mapped file</div><br xmlns="http://www.w3.org/1999/xhtml"><img id="MemMapPersisted" alt="Shows views to a memory-mapped file." src="memoryMappedFiles_elemei/IC378559.png" title="Shows views to a memory-mapped file."></div><div class="LW_CollapsibleArea_Container" xmlns=""><div class="LW_CollapsibleArea_TitleDiv"><span class="LW_CollapsibleArea_Title">Programming with Memory-Mapped Files</span><div class="LW_CollapsibleArea_HrDiv"><hr class="LW_CollapsibleArea_Hr"></div></div><a id="sectionToggle1" xmlns="http://www.w3.org/1999/xhtml"></a><p xmlns="http://www.w3.org/1999/xhtml">The following table provides a guide for using memory-mapped file objects and their members.</p><div class="caption" xmlns="http://www.w3.org/1999/xhtml"></div><div class="tableSection" xmlns="http://www.w3.org/1999/xhtml"><table><tbody><tr><th><p>Task</p></th><th><p>Methods or properties to use</p></th></tr><tr><td><p>To obtain a <span><a href="http://msdn.microsoft.com/en-us/library/system.io.memorymappedfiles.memorymappedfile.aspx">MemoryMappedFile</a></span> object that represents a persisted memory-mapped file from a file on disk.</p></td><td><p><span><a href="http://msdn.microsoft.com/en-us/library/system.io.memorymappedfiles.memorymappedfile.createfromfile.aspx">MemoryMappedFile<span xmlns="">.</span>CreateFromFile</a></span> method.</p></td></tr><tr><td><p>To obtain a <span><a href="http://msdn.microsoft.com/en-us/library/system.io.memorymappedfiles.memorymappedfile.aspx">MemoryMappedFile</a></span> object that represents a non-persisted memory-mapped file (not associated with a file on disk).</p></td><td><p><span><a href="http://msdn.microsoft.com/en-us/library/system.io.memorymappedfiles.memorymappedfile.createnew.aspx">MemoryMappedFile<span xmlns="">.</span>CreateNew</a></span> method.</p><p>- or -</p><p><span><a href="http://msdn.microsoft.com/en-us/library/system.io.memorymappedfiles.memorymappedfile.createoropen.aspx">MemoryMappedFile<span xmlns="">.</span>CreateOrOpen</a></span> method.</p></td></tr><tr><td><p>To obtain a <span><a href="http://msdn.microsoft.com/en-us/library/system.io.memorymappedfiles.memorymappedfile.aspx">MemoryMappedFile</a></span> object of an existing memory-mapped file (either persisted or non-persisted).</p></td><td><p><span><a href="http://msdn.microsoft.com/en-us/library/system.io.memorymappedfiles.memorymappedfile.openexisting.aspx">MemoryMappedFile<span xmlns="">.</span>OpenExisting</a></span> method.</p></td></tr><tr><td><p>To obtain a <span><a href="http://msdn.microsoft.com/en-us/library/system.io.unmanagedmemorystream.aspx">UnmanagedMemoryStream</a></span> object for a sequentially accessed view to the memory-mapped file.</p></td><td><p><span><a href="http://msdn.microsoft.com/en-us/library/system.io.memorymappedfiles.memorymappedfile.createviewstream.aspx">MemoryMappedFile<span xmlns="">.</span>CreateViewStream</a></span> method.</p></td></tr><tr><td><p>To obtain a <span><a href="http://msdn.microsoft.com/en-us/library/system.io.unmanagedmemoryaccessor.aspx">UnmanagedMemoryAccessor</a></span> object for a random access view to a memory-mapped fie.</p></td><td><p><span><a href="http://msdn.microsoft.com/en-us/library/system.io.memorymappedfiles.memorymappedfile.createviewaccessor.aspx">MemoryMappedFile<span xmlns="">.</span>CreateViewAccessor</a></span> method.</p></td></tr><tr><td><p>To obtain a <span><a href="http://msdn.microsoft.com/en-us/library/microsoft.win32.safehandles.safememorymappedviewhandle.aspx">SafeMemoryMappedViewHandle</a></span> object to use with unmanaged code.</p></td><td><p><span><a href="http://msdn.microsoft.com/en-us/library/system.io.memorymappedfiles.memorymappedfile.safememorymappedfilehandle.aspx">MemoryMappedFile<span xmlns="">.</span>SafeMemoryMappedFileHandle</a></span> property.</p><p>- or -</p><p><span><a href="http://msdn.microsoft.com/en-us/library/system.io.memorymappedfiles.memorymappedviewaccessor.safememorymappedviewhandle.aspx">MemoryMappedViewAccessor<span xmlns="">.</span>SafeMemoryMappedViewHandle</a></span> property.</p><p>- or -</p><p><span><a href="http://msdn.microsoft.com/en-us/library/system.io.memorymappedfiles.memorymappedviewstream.safememorymappedviewhandle.aspx">MemoryMappedViewStream<span xmlns="">.</span>SafeMemoryMappedViewHandle</a></span> property.</p></td></tr><tr><td><p>To delay allocating memory until a view is created (non-persisted files only).</p><p>(To determine the current system page size, use the <span><a href="http://msdn.microsoft.com/en-us/library/system.environment.systempagesize.aspx">Environment<span xmlns="">.</span>SystemPageSize</a></span> property.)</p></td><td><p><span><a href="http://msdn.microsoft.com/en-us/library/system.io.memorymappedfiles.memorymappedfile.createnew.aspx">CreateNew</a></span> method with the <span><a href="http://msdn.microsoft.com/en-us/library/system.io.memorymappedfiles.memorymappedfileoptions.aspx">MemoryMappedFileOptions<span xmlns="">.</span>DelayAllocatePages</a></span> value.</p><p>- or -</p><p><span><a href="http://msdn.microsoft.com/en-us/library/system.io.memorymappedfiles.memorymappedfile.createoropen.aspx">CreateOrOpen</a></span> methods that have a <span><a href="http://msdn.microsoft.com/en-us/library/system.io.memorymappedfiles.memorymappedfileoptions.aspx">MemoryMappedFileOptions</a></span> enumeration as a parameter. </p></td></tr></tbody></table></div><h3 class="subHeading" xmlns="http://www.w3.org/1999/xhtml">Security</h3><div class="subsection" xmlns="http://www.w3.org/1999/xhtml"><p>You can apply access rights when you create a memory-mapped file, by using the following methods that take a <span><a href="http://msdn.microsoft.com/en-us/library/system.io.memorymappedfiles.memorymappedfileaccess.aspx">MemoryMappedFileAccess</a></span> enumeration as a parameter: </p><ul><li><p><span><a href="http://msdn.microsoft.com/en-us/library/system.io.memorymappedfiles.memorymappedfile.createfromfile.aspx">MemoryMappedFile<span xmlns="">.</span>CreateFromFile</a></span></p></li><li><p><span><a href="http://msdn.microsoft.com/en-us/library/system.io.memorymappedfiles.memorymappedfile.createnew.aspx">MemoryMappedFile<span xmlns="">.</span>CreateNew</a></span></p></li><li><p><span><a href="http://msdn.microsoft.com/en-us/library/system.io.memorymappedfiles.memorymappedfile.createoropen.aspx">MemoryMappedFile<span xmlns="">.</span>CreateOrOpen</a></span></p></li></ul><p>You can specify access rights for opening an existing memory-mapped file by using the <span><a href="http://msdn.microsoft.com/en-us/library/system.io.memorymappedfiles.memorymappedfile.openexisting.aspx">OpenExisting</a></span> methods that take an <span><a href="http://msdn.microsoft.com/en-us/library/system.io.memorymappedfiles.memorymappedfilerights.aspx">MemoryMappedFileRights</a></span> as a parameter.</p><p>In addition, you can include a <span><a href="http://msdn.microsoft.com/en-us/library/system.io.memorymappedfiles.memorymappedfilesecurity.aspx">MemoryMappedFileSecurity</a></span> object that contains predefined access rules. </p><p>To apply new or changed access rules to a memory-mapped file, use the <span><a href="http://msdn.microsoft.com/en-us/library/system.io.memorymappedfiles.memorymappedfile.setaccesscontrol.aspx">SetAccessControl</a></span> method. To retrieve access or audit rules from an existing file, use the <span><a href="http://msdn.microsoft.com/en-us/library/system.io.memorymappedfiles.memorymappedfile.getaccesscontrol.aspx">GetAccessControl</a></span> method.</p></div></div><div class="LW_CollapsibleArea_Container" xmlns=""><div class="LW_CollapsibleArea_TitleDiv"><span class="LW_CollapsibleArea_Title">Examples</span><div class="LW_CollapsibleArea_HrDiv"><hr class="LW_CollapsibleArea_Hr"></div></div><a id="sectionToggle2" xmlns="http://www.w3.org/1999/xhtml"></a><h3 class="subHeading" xmlns="http://www.w3.org/1999/xhtml">Persisted Memory-Mapped Files</h3><div class="subsection" xmlns="http://www.w3.org/1999/xhtml"><p>The <span><a href="http://msdn.microsoft.com/en-us/library/system.io.memorymappedfiles.memorymappedfile.createfromfile.aspx">CreateFromFile</a></span> methods create a memory-mapped file from an existing file on disk.</p><p>The following example creates a memory-mapped view of a part of an extremely large file and manipulates a portion of it.</p><div id="snippetGroup"><div class="LW_CodeSnippetContainer" xmlns=""><a name="CodeSpippet0"></a><div class="LW_CodeSnippetContainerTabs"><div class="LW_CodeSnippetContainerTabLeft"><img class="cl_lw_codesnippet_lt_tab" src="memoryMappedFiles_elemei/8841a3a4fc3a5f17f74da3b076fe248a.png"></div><div class="LW_CodeSnippetContainerTabFirst"><a href="javascript:%20CodeSnippet_SetLanguage('Visual%20Basic');" class="LW_CodeSnippetContainerTabLinkBold">VB</a></div><div class="LW_CodeSnippetContainerTabActive"><a class="LW_CodeSnippetContainerTabLinkBold">C#</a></div><div class="LW_CodeSnippetContainerTab"><a href="javascript:%20CodeSnippet_SetLanguage('Visual%20C++');" class="LW_CodeSnippetContainerTabLinkNormal">C++</a></div><div class="LW_CodeSnippetContainerTab"><a href="javascript:%20CodeSnippet_SetLanguage('F#');" class="LW_CodeSnippetContainerTabLinkNormal">F#</a></div><div class="LW_CodeSnippetContainerTabLast"><a href="javascript:%20CodeSnippet_SetLanguage('JScript');" class="LW_CodeSnippetContainerTabLinkNormal">JScript</a></div><div class="LW_CodeSnippetContainerTabRight"><img class="cl_lw_codesnippet_rt_tab" src="memoryMappedFiles_elemei/8841a3a4fc3a5f17f74da3b076fe248a.png"></div></div><div class="LW_CodeSnippetContainerCodeCollection"><div class="LW_CodeSnippetToolBar"><div class="LW_CodeSnippetToolBarText" style=""><a title="Copy to clipboard." href="javascript:CodeSnippet_CopyCode('CodeSnippetContainerCode0');">Copy</a></div></div><div id="CodeSnippetContainerCode0" class="LW_CodeSnippetContainerCode"><div style="color: Black;"><pre>
<span style="color: Blue;">using</span> System;
<span style="color: Blue;">using</span> System.IO;
<span style="color: Blue;">using</span> System.IO.MemoryMappedFiles;
<span style="color: Blue;">using</span> System.Runtime.InteropServices;

<span style="color: Blue;">class</span> Program
{
	<span style="color: Blue;">static</span> <span style="color: Blue;">void</span> Main(<span style="color: Blue;">string</span>[] args)
	{
		<span style="color: Blue;">long</span> offset = 0x10000000; <span style="color: Green;">// 256 megabytes</span>
		<span style="color: Blue;">long</span> length = 0x20000000; <span style="color: Green;">// 512 megabytes</span>

        <span style="color: Green;">// Create the memory-mapped file.</span>
		<span style="color: Blue;">using</span> (<span style="color: Blue;">var</span> mmf = 
			MemoryMappedFile.CreateFromFile(<span style="color: rgb(163, 21, 21);">@"c:\ExtremelyLargeImage.data"</span>,
														FileMode.Open,<span style="color: rgb(163, 21, 21);">"ImgA"</span>))
		{
        <span style="color: Green;">// Create a random access view, from the 256th megabyte (the offset)</span>
        <span style="color: Green;">// to the 768th megabyte (the offset plus length).</span>
        <span style="color: Blue;">using</span> (<span style="color: Blue;">var</span> accessor = mmf.CreateViewAccessor(offset, length))
			{

				<span style="color: Blue;">int</span> colorSize = Marshal.SizeOf(<span style="color: Blue;">typeof</span>(MyColor));
				MyColor color;

				<span style="color: Green;">// Make changes to the view.</span>
				<span style="color: Blue;">for</span> (<span style="color: Blue;">long</span> i = 0; i &lt; length; i += colorSize)
				{
					accessor.Read(i, <span style="color: Blue;">out</span> color);
					color.Brighten(10);
					accessor.Write(i, <span style="color: Blue;">ref</span> color);
				}
			}
		}

	}

	<span style="color: Blue;">public</span> <span style="color: Blue;">struct</span> MyColor
	{
		<span style="color: Blue;">public</span> <span style="color: Blue;">short</span> Red;
		<span style="color: Blue;">public</span> <span style="color: Blue;">short</span> Green;
		<span style="color: Blue;">public</span> <span style="color: Blue;">short</span> Blue;
		<span style="color: Blue;">public</span> <span style="color: Blue;">short</span> Alpha;

		<span style="color: Green;">// Make the view brigher.</span>
		<span style="color: Blue;">public</span> <span style="color: Blue;">void</span> Brighten(<span style="color: Blue;">short</span> value)
		{
			Red = (<span style="color: Blue;">short</span>)Math.Min(<span style="color: Blue;">short</span>.MaxValue, (<span style="color: Blue;">int</span>)Red + value);
			Green = (<span style="color: Blue;">short</span>)Math.Min(<span style="color: Blue;">short</span>.MaxValue, (<span style="color: Blue;">int</span>)Green + value);
			Blue = (<span style="color: Blue;">short</span>)Math.Min(<span style="color: Blue;">short</span>.MaxValue, (<span style="color: Blue;">int</span>)Blue + value);
			Alpha = (<span style="color: Blue;">short</span>)Math.Min(<span style="color: Blue;">short</span>.MaxValue, (<span style="color: Blue;">int</span>)Alpha + value);
		}
	}

}


</pre></div></div></div></div></div><p>The following example opens the same memory-mapped file for another process.</p><div id="snippetGroup1"><div class="LW_CodeSnippetContainer" xmlns=""><a name="CodeSpippet1"></a><div class="LW_CodeSnippetContainerTabs"><div class="LW_CodeSnippetContainerTabLeft"><img class="cl_lw_codesnippet_lt_tab" src="memoryMappedFiles_elemei/8841a3a4fc3a5f17f74da3b076fe248a.png"></div><div class="LW_CodeSnippetContainerTabFirst"><a href="javascript:%20CodeSnippet_SetLanguage('Visual%20Basic');" class="LW_CodeSnippetContainerTabLinkBold">VB</a></div><div class="LW_CodeSnippetContainerTabActive"><a class="LW_CodeSnippetContainerTabLinkBold">C#</a></div><div class="LW_CodeSnippetContainerTab"><a href="javascript:%20CodeSnippet_SetLanguage('Visual%20C++');" class="LW_CodeSnippetContainerTabLinkNormal">C++</a></div><div class="LW_CodeSnippetContainerTab"><a href="javascript:%20CodeSnippet_SetLanguage('F#');" class="LW_CodeSnippetContainerTabLinkNormal">F#</a></div><div class="LW_CodeSnippetContainerTabLast"><a href="javascript:%20CodeSnippet_SetLanguage('JScript');" class="LW_CodeSnippetContainerTabLinkNormal">JScript</a></div><div class="LW_CodeSnippetContainerTabRight"><img class="cl_lw_codesnippet_rt_tab" src="memoryMappedFiles_elemei/8841a3a4fc3a5f17f74da3b076fe248a.png"></div></div><div class="LW_CodeSnippetContainerCodeCollection"><div class="LW_CodeSnippetToolBar"><div class="LW_CodeSnippetToolBarText" style=""><a title="Copy to clipboard." href="javascript:CodeSnippet_CopyCode('CodeSnippetContainerCode1');">Copy</a></div></div><div id="CodeSnippetContainerCode1" class="LW_CodeSnippetContainerCode"><div style="color: Black;"><pre>
<span style="color: Blue;">using</span> System;
<span style="color: Blue;">using</span> System.IO.MemoryMappedFiles;
<span style="color: Blue;">using</span> System.Runtime.InteropServices;


<span style="color: Blue;">class</span> Program
{
    <span style="color: Blue;">static</span> <span style="color: Blue;">void</span> Main(<span style="color: Blue;">string</span>[] args)
    {
        <span style="color: Green;">// Assumes another process has created the memory-mapped file.</span>
        <span style="color: Blue;">using</span> (<span style="color: Blue;">var</span> mmf = MemoryMappedFile.OpenExisting(<span style="color: rgb(163, 21, 21);">"ImgA"</span>))
        {
            <span style="color: Blue;">using</span> (<span style="color: Blue;">var</span> accessor = mmf.CreateViewAccessor(4000000, 2000000))
            {
                <span style="color: Blue;">int</span> colorSize = Marshal.SizeOf(<span style="color: Blue;">typeof</span>(MyColor));
                MyColor color;

                <span style="color: Green;">// Make changes to the view.</span>
                <span style="color: Blue;">for</span> (<span style="color: Blue;">long</span> i = 0; i &lt; 1500000; i += colorSize)
                {
                    accessor.Read(i, <span style="color: Blue;">out</span> color);
                    color.Brighten(20);
                    accessor.Write(i, <span style="color: Blue;">ref</span> color);
                }
            }
        }
    }
}

<span style="color: Blue;">public</span> <span style="color: Blue;">struct</span> MyColor
{
    <span style="color: Blue;">public</span> <span style="color: Blue;">short</span> Red;
    <span style="color: Blue;">public</span> <span style="color: Blue;">short</span> Green;
    <span style="color: Blue;">public</span> <span style="color: Blue;">short</span> Blue;
    <span style="color: Blue;">public</span> <span style="color: Blue;">short</span> Alpha;

    <span style="color: Green;">// Make the view brigher.</span>
    <span style="color: Blue;">public</span> <span style="color: Blue;">void</span> Brighten(<span style="color: Blue;">short</span> value)
    {
        Red = (<span style="color: Blue;">short</span>)Math.Min(<span style="color: Blue;">short</span>.MaxValue, (<span style="color: Blue;">int</span>)Red + value);
        Green = (<span style="color: Blue;">short</span>)Math.Min(<span style="color: Blue;">short</span>.MaxValue, (<span style="color: Blue;">int</span>)Green + value);
        Blue = (<span style="color: Blue;">short</span>)Math.Min(<span style="color: Blue;">short</span>.MaxValue, (<span style="color: Blue;">int</span>)Blue + value);
        Alpha = (<span style="color: Blue;">short</span>)Math.Min(<span style="color: Blue;">short</span>.MaxValue, (<span style="color: Blue;">int</span>)Alpha + value);
    }
}


</pre></div></div></div></div></div></div><h3 class="subHeading" xmlns="http://www.w3.org/1999/xhtml">Non-Persisted Memory-Mapped Files</h3><div class="subsection" xmlns="http://www.w3.org/1999/xhtml"><p>The <span><a href="http://msdn.microsoft.com/en-us/library/system.io.memorymappedfiles.memorymappedfile.createnew.aspx">CreateNew</a></span> and <span><a href="http://msdn.microsoft.com/en-us/library/system.io.memorymappedfiles.memorymappedfile.createoropen.aspx">CreateOrOpen</a></span> methods create a memory-mapped file that is not mapped to an existing file on disk.</p><p>The
 following example consists of three separate processes (console 
applications) that write Boolean values to a memory-mapped file. The 
following sequence of actions occur:</p><ol><li><p><span class="code">Process A</span> creates the memory-mapped file and writes a value to it. </p></li><li><p><span class="code">Process B</span> opens the memory-mapped file and writes a value to it. </p></li><li><p><span class="code">Process C</span> opens the memory-mapped file and writes a value to it. </p></li><li><p><span class="code">Process A</span> reads and displays the values from the memory-mapped file. </p></li><li><p>After <span class="code">Process A</span> is finished with the memory-mapped file, the file is immediately reclaimed by garbage collection.</p></li></ol><p>To run this example, do the following:</p><ol><li><p>Compile the applications and open three Command Prompt windows.</p></li><li><p>In the first Command Prompt window, run <span class="code">Process A</span>.</p></li><li><p>In the second Command Prompt window, run <span class="code">Process B</span>.</p></li><li><p>Return to <span class="code">Process A</span> and press ENTER.</p></li><li><p>In the third Command Prompt window, run <span class="code">Process C</span>.</p></li><li><p>Return to <span class="code">Process A</span> and press ENTER.</p></li></ol><p>The output of <span class="code">Process A</span> is as follows:</p><div class="LW_CodeSnippetContainer" xmlns=""><a name="CodeSpippet2"></a><div class="LW_CodeSnippetContainerCodeCollection"><div class="LW_CodeSnippetToolBar"><div class="LW_CodeSnippetToolBarText" style=""><a title="Copy to clipboard." href="javascript:CodeSnippet_CopyCode('CodeSnippetContainerCode2');">Copy</a></div></div><div id="CodeSnippetContainerCode2" class="LW_CodeSnippetContainerCode"><div style="color: Black;"><pre>Start Process B and press ENTER to continue.
Start Process C and press ENTER to continue.
Process A says: True
Process B says: False
Process C says: True
</pre></div></div></div></div><p><span class="label">Process A</span></p><div id="snippetGroup2"><div class="LW_CodeSnippetContainer" xmlns=""><a name="CodeSpippet3"></a><div class="LW_CodeSnippetContainerTabs"><div class="LW_CodeSnippetContainerTabLeft"><img class="cl_lw_codesnippet_lt_tab" src="memoryMappedFiles_elemei/8841a3a4fc3a5f17f74da3b076fe248a.png"></div><div class="LW_CodeSnippetContainerTabFirst"><a href="javascript:%20CodeSnippet_SetLanguage('Visual%20Basic');" class="LW_CodeSnippetContainerTabLinkBold">VB</a></div><div class="LW_CodeSnippetContainerTabActive"><a class="LW_CodeSnippetContainerTabLinkBold">C#</a></div><div class="LW_CodeSnippetContainerTab"><a href="javascript:%20CodeSnippet_SetLanguage('Visual%20C++');" class="LW_CodeSnippetContainerTabLinkNormal">C++</a></div><div class="LW_CodeSnippetContainerTab"><a href="javascript:%20CodeSnippet_SetLanguage('F#');" class="LW_CodeSnippetContainerTabLinkNormal">F#</a></div><div class="LW_CodeSnippetContainerTabLast"><a href="javascript:%20CodeSnippet_SetLanguage('JScript');" class="LW_CodeSnippetContainerTabLinkNormal">JScript</a></div><div class="LW_CodeSnippetContainerTabRight"><img class="cl_lw_codesnippet_rt_tab" src="memoryMappedFiles_elemei/8841a3a4fc3a5f17f74da3b076fe248a.png"></div></div><div class="LW_CodeSnippetContainerCodeCollection"><div class="LW_CodeSnippetToolBar"><div class="LW_CodeSnippetToolBarText" style=""><a title="Copy to clipboard." href="javascript:CodeSnippet_CopyCode('CodeSnippetContainerCode3');">Copy</a></div></div><div id="CodeSnippetContainerCode3" class="LW_CodeSnippetContainerCode"><div style="color: Black;"><pre>
<span style="color: Blue;">using</span> System;
<span style="color: Blue;">using</span> System.IO;
<span style="color: Blue;">using</span> System.IO.MemoryMappedFiles;
<span style="color: Blue;">using</span> System.Threading;

<span style="color: Blue;">class</span> Program
{
    <span style="color: Green;">// Process A:</span>
    <span style="color: Blue;">static</span> <span style="color: Blue;">void</span> Main(<span style="color: Blue;">string</span>[] args)
    {
        <span style="color: Blue;">using</span> (MemoryMappedFile mmf = MemoryMappedFile.CreateNew(<span style="color: rgb(163, 21, 21);">"testmap"</span>, 10000))
        {


            <span style="color: Blue;">bool</span> mutexCreated;
            Mutex mutex = <span style="color: Blue;">new</span> Mutex(<span style="color: Blue;">true</span>, <span style="color: rgb(163, 21, 21);">"testmapmutex"</span>, <span style="color: Blue;">out</span> mutexCreated);
            <span style="color: Blue;">using</span> (MemoryMappedViewStream stream = mmf.CreateViewStream())
            {
                BinaryWriter writer = <span style="color: Blue;">new</span> BinaryWriter(stream);
                writer.Write(1);
            }
            mutex.ReleaseMutex();

            Console.WriteLine(<span style="color: rgb(163, 21, 21);">"Start Process B and press ENTER to continue."</span>);
            Console.ReadLine();

            Console.WriteLine(<span style="color: rgb(163, 21, 21);">"Start Process C and press ENTER to continue."</span>);
            Console.ReadLine();

            mutex.WaitOne();
            <span style="color: Blue;">using</span> (MemoryMappedViewStream stream = mmf.CreateViewStream())
            {
                BinaryReader reader = <span style="color: Blue;">new</span> BinaryReader(stream);
                Console.WriteLine(<span style="color: rgb(163, 21, 21);">"Process A says: {0}"</span>, reader.ReadBoolean());
                Console.WriteLine(<span style="color: rgb(163, 21, 21);">"Process B says: {0}"</span>, reader.ReadBoolean());
                Console.WriteLine(<span style="color: rgb(163, 21, 21);">"Process C says: {0}"</span>, reader.ReadBoolean());
            }
            mutex.ReleaseMutex();
        }
    }
}


</pre></div></div></div></div></div><p><span class="label">Process B</span></p><div id="snippetGroup3"><div class="LW_CodeSnippetContainer" xmlns=""><a name="CodeSpippet4"></a><div class="LW_CodeSnippetContainerTabs"><div class="LW_CodeSnippetContainerTabLeft"><img class="cl_lw_codesnippet_lt_tab" src="memoryMappedFiles_elemei/8841a3a4fc3a5f17f74da3b076fe248a.png"></div><div class="LW_CodeSnippetContainerTabFirst"><a href="javascript:%20CodeSnippet_SetLanguage('Visual%20Basic');" class="LW_CodeSnippetContainerTabLinkBold">VB</a></div><div class="LW_CodeSnippetContainerTabActive"><a class="LW_CodeSnippetContainerTabLinkBold">C#</a></div><div class="LW_CodeSnippetContainerTab"><a href="javascript:%20CodeSnippet_SetLanguage('Visual%20C++');" class="LW_CodeSnippetContainerTabLinkNormal">C++</a></div><div class="LW_CodeSnippetContainerTab"><a href="javascript:%20CodeSnippet_SetLanguage('F#');" class="LW_CodeSnippetContainerTabLinkNormal">F#</a></div><div class="LW_CodeSnippetContainerTabLast"><a href="javascript:%20CodeSnippet_SetLanguage('JScript');" class="LW_CodeSnippetContainerTabLinkNormal">JScript</a></div><div class="LW_CodeSnippetContainerTabRight"><img class="cl_lw_codesnippet_rt_tab" src="memoryMappedFiles_elemei/8841a3a4fc3a5f17f74da3b076fe248a.png"></div></div><div class="LW_CodeSnippetContainerCodeCollection"><div class="LW_CodeSnippetToolBar"><div class="LW_CodeSnippetToolBarText" style=""><a title="Copy to clipboard." href="javascript:CodeSnippet_CopyCode('CodeSnippetContainerCode4');">Copy</a></div></div><div id="CodeSnippetContainerCode4" class="LW_CodeSnippetContainerCode"><div style="color: Black;"><pre>
<span style="color: Blue;">using</span> System;
<span style="color: Blue;">using</span> System.IO;
<span style="color: Blue;">using</span> System.IO.MemoryMappedFiles;
<span style="color: Blue;">using</span> System.Threading;

<span style="color: Blue;">class</span> Program
{
    <span style="color: Green;">// Process B:</span>
    <span style="color: Blue;">static</span> <span style="color: Blue;">void</span> Main(<span style="color: Blue;">string</span>[] args)
    {
        <span style="color: Blue;">try</span>
        {
            <span style="color: Blue;">using</span> (MemoryMappedFile mmf = MemoryMappedFile.OpenExisting(<span style="color: rgb(163, 21, 21);">"testmap"</span>))
            {

                Mutex mutex = Mutex.OpenExisting(<span style="color: rgb(163, 21, 21);">"testmapmutex"</span>);
                mutex.WaitOne();

                <span style="color: Blue;">using</span> (MemoryMappedViewStream stream = mmf.CreateViewStream(1, 0))
                {
                    BinaryWriter writer = <span style="color: Blue;">new</span> BinaryWriter(stream);
                    writer.Write(0);
                }
                mutex.ReleaseMutex();
            }
        }
        <span style="color: Blue;">catch</span> (FileNotFoundException)
        {
            Console.WriteLine(<span style="color: rgb(163, 21, 21);">"Memory-mapped file does not exist. Run Process A first."</span>);
        }
    }
}


</pre></div></div></div></div></div><p><span class="label">Process C</span></p><div id="snippetGroup4"><div class="LW_CodeSnippetContainer" xmlns=""><a name="CodeSpippet5"></a><div class="LW_CodeSnippetContainerTabs"><div class="LW_CodeSnippetContainerTabLeft"><img class="cl_lw_codesnippet_lt_tab" src="memoryMappedFiles_elemei/8841a3a4fc3a5f17f74da3b076fe248a.png"></div><div class="LW_CodeSnippetContainerTabFirst"><a href="javascript:%20CodeSnippet_SetLanguage('Visual%20Basic');" class="LW_CodeSnippetContainerTabLinkBold">VB</a></div><div class="LW_CodeSnippetContainerTabActive"><a class="LW_CodeSnippetContainerTabLinkBold">C#</a></div><div class="LW_CodeSnippetContainerTab"><a href="javascript:%20CodeSnippet_SetLanguage('Visual%20C++');" class="LW_CodeSnippetContainerTabLinkNormal">C++</a></div><div class="LW_CodeSnippetContainerTab"><a href="javascript:%20CodeSnippet_SetLanguage('F#');" class="LW_CodeSnippetContainerTabLinkNormal">F#</a></div><div class="LW_CodeSnippetContainerTabLast"><a href="javascript:%20CodeSnippet_SetLanguage('JScript');" class="LW_CodeSnippetContainerTabLinkNormal">JScript</a></div><div class="LW_CodeSnippetContainerTabRight"><img class="cl_lw_codesnippet_rt_tab" src="memoryMappedFiles_elemei/8841a3a4fc3a5f17f74da3b076fe248a.png"></div></div><div class="LW_CodeSnippetContainerCodeCollection"><div class="LW_CodeSnippetToolBar"><div class="LW_CodeSnippetToolBarText" style=""><a title="Copy to clipboard." href="javascript:CodeSnippet_CopyCode('CodeSnippetContainerCode5');">Copy</a></div></div><div id="CodeSnippetContainerCode5" class="LW_CodeSnippetContainerCode"><div style="color: Black;"><pre>
<span style="color: Blue;">using</span> System;
<span style="color: Blue;">using</span> System.IO;
<span style="color: Blue;">using</span> System.IO.MemoryMappedFiles;
<span style="color: Blue;">using</span> System.Threading;

<span style="color: Blue;">class</span> Program
{
    <span style="color: Green;">// Process C:</span>
    <span style="color: Blue;">static</span> <span style="color: Blue;">void</span> Main(<span style="color: Blue;">string</span>[] args)
    {
        <span style="color: Blue;">try</span>
        {
            <span style="color: Blue;">using</span> (MemoryMappedFile mmf = MemoryMappedFile.OpenExisting(<span style="color: rgb(163, 21, 21);">"testmap"</span>))
            {

                Mutex mutex = Mutex.OpenExisting(<span style="color: rgb(163, 21, 21);">"testmapmutex"</span>);
                mutex.WaitOne();

                <span style="color: Blue;">using</span> (MemoryMappedViewStream stream = mmf.CreateViewStream(2, 0))
                {
                    BinaryWriter writer = <span style="color: Blue;">new</span> BinaryWriter(stream);
                    writer.Write(1);
                }
                mutex.ReleaseMutex();
            }
        }
        <span style="color: Blue;">catch</span> (FileNotFoundException)
        {
            Console.WriteLine(<span style="color: rgb(163, 21, 21);">"Memory-mapped file does not exist. Run Process A first, then B."</span>);
        }
    }
}


</pre></div></div></div></div></div></div></div><div class="LW_CollapsibleArea_Container" xmlns=""><div class="LW_CollapsibleArea_TitleDiv"><span class="LW_CollapsibleArea_Title">See Also</span><div class="LW_CollapsibleArea_HrDiv"><hr class="LW_CollapsibleArea_Hr"></div></div><a id="seeAlsoToggle" xmlns="http://www.w3.org/1999/xhtml"></a><h4 class="subHeading" xmlns="http://www.w3.org/1999/xhtml">Other Resources</h4><div class="seeAlsoStyle" xmlns="http://www.w3.org/1999/xhtml"><span><a href="http://msdn.microsoft.com/en-us/library/k3352a4t.aspx">File and Stream I/O</a></span></div></div></div></div></div></div><div class="topicEndLine"></div><div id="CommunityContent" class="CommunityContent"><div class="CommunityContentContainer"><div id="CommunityContentHeader" class="CommunityContentHeader"><div class="CommunityContentHeaderTitleContainer"><span class="CommunityContentHeaderTitle h1">Community Content</span><a href="http://msdn.microsoft.com/en-us/library/community/add/dd997372.aspx" title="Add">Add</a></div><div class="CommunityContentFaq"><a href="http://msdn.microsoft.com/en-us/library/community-edits.rss?topic=dd997372%7Cen-us%7CVS.100" title="Annotations"><img class="cl_rss_button" alt="Annotations" src="memoryMappedFiles_elemei/030c41d9079671d09a62d8e2c1db6973.gif"></a><a href="http://msdn.microsoft.com/en-us/library/community-msdnwikifaq.aspx" title="FAQ">FAQ</a></div><div style="clear: both;"></div></div></div></div></div></div><div class="footer"><div id="footer" class="footerContainer cl_footer_slice"><div class="footerLogoContainer"><div class="footerContent"><div class="copyright">
      © 2010 Microsoft Corporation. All rights reserved.</div><div class="footerLogo cl_footer_logo"></div><a href="http://msdn.microsoft.com/cc300389.aspx">Terms of Use</a><span class="pipe"> | </span><a href="http://www.microsoft.com/library/toolbar/3.0/trademarks/en-us.mspx">Trademarks</a><span class="pipe"> | </span><a href="http://www.microsoft.com/info/privacy.mspx">Privacy Statement</a><span class="pipe">| </span><a onclick="javascript:ShowFeedbackDialog();" title="Feedback" class="FeedbackLink" href="#footerLink">
      Feedback
        <span class="FeedbackButton clip20x21" id="FeedbackButton"><img class="cl_footer_feedback_icon" src="memoryMappedFiles_elemei/8841a3a4fc3a5f17f74da3b076fe248a.png" alt="Feedback"></span></a><div id="FeedbackContainer" class="FeedbackContainer"><form method="post" action="/en-us/library/feedback/add/dd997372.aspx"><div class="FeedbackTitleContainer"><div class="FeedbackTitle">
            Feedback</div><div class="FeedbackCancel"><a href="javascript:;" onclick="document.getElementById('FeedbackContainer').style.display = 'none';">x</a></div></div><div class="FeedbackData"><div class="FeedbackInfoText">
            Tell us about your experience...
        </div><div class="QuestionText">
            Did the page load quickly?
        </div><div class="AnswerText"><span>
                Yes<span><input id="searchBox" name="searchBox" value="1" type="radio"></span></span><span>
                No<span><input id="searchBox" name="searchBox" value="0" type="radio"></span></span></div><div class="QuestionText">
            Do you like the page design?
        </div><div class="AnswerText"><span>
                Yes<span><input id="tabbedCode" name="tabbedCode" value="1" type="radio"></span></span><span>
                No<span><input id="tabbedCode" name="tabbedCode" value="0" type="radio"></span></span></div><div class="QuestionText">
            How useful is this topic?
        </div><div class="FeedbackGraphicHolder clip269x23"><img alt="" src="memoryMappedFiles_elemei/8841a3a4fc3a5f17f74da3b076fe248a.png" class="cl_online_scale FeedbackSiderGraphic"></div><div class="RadioButtonHolder"><div class="RateRadioOne"><input id="topicUseful" name="topicUseful" title="Really disliked it" value="1" type="radio"></div><div class="RateRadio"><input id="topicUseful" name="topicUseful" title="Disliked it" value="2" type="radio"></div><div class="RateRadio"><input id="topicUseful" name="topicUseful" title="OK" value="3" type="radio"></div><div class="RateRadio"><input id="topicUseful" name="topicUseful" title="Good" value="4" type="radio"></div><div class="RateRadioLast"><input id="topicUseful" name="topicUseful" title="Really Good" value="5" type="radio"></div></div><div class="QuestionText">
            Tell us more
        </div><div class="FeedbackTextAreaContainer"><textarea name="feedbackText" cols="25" rows="5" class="FeedbackTextArea" onfocus="document.onkeydown = '';" onblur="document.onkeydown = Presskey;" onkeyup="LimitText(this, 4000);" onkeydown="LimitText(this, 4000);"></textarea><textarea id="feedbackDescription" name="feedbackDescription" cols="25" rows="10" style="display: none;" onkeyup="LimitText(this, 4000);" onkeydown="LimitText(this, 4000);">Enter description here.</textarea><input id="feedbackPriority" name="feedbackPriority" value="" type="hidden"><input id="feedbackSourceUrl" name="feedbackSourceUrl" value="" type="hidden"><input id="ClientIP" name="ClientIP" value="" type="hidden"><input id="ClientOS" name="ClientOS" value="" type="hidden"><input id="ClientBrowser" name="ClientBrowser" value="" type="hidden"><input id="ClientTime" name="ClientTime" value="" type="hidden"><input id="ClientTimeZone" name="ClientTimeZone" value="" type="hidden"></div><div><input value="Send" class="FeedbackSubmit" onclick="document.getElementById('feedbackDescription').value='';document.getElementById('feedBackVersion').value = '-1';" type="submit"></div></div><input id="returnUrl" name="returnUrl" value="http://msdn.microsoft.com/en-us/library/dd997372.aspx" type="hidden"><input id="feedBackVersion" name="feedBackVersion" value="1" type="hidden"></form></div></div></div></div></div><div class="MetricsContainer"><div class="WebtrendsContainer"><script type="text/javascript" language="javascript">
//<![CDATA[
  var literalNormalizedUrl = '/en-us/library/dd997372(d=lightweight,l=en-us,v=VS.100).aspx';
  var wt_nvr_ru = 'WT_NVR_RU';
  var wt_fpcdom = '.microsoft.com';
  var wt_domlist = 'msdn.microsoft.com';
  var wt_pathlist = '';
  var wt_paramlist = 'DCSext.mtps_devcenter';
  var wt_siteid = 'MSDN';
  var gDomain = 'm.webtrends.com';
  var gDcsId = 'dcsmgru7m99k7mqmgrhudo0k8_8c6m';
  var gFpc = 'WT_FPC';
  if (document.cookie.indexOf(gFpc + "=") == -1) {
    document.write("<scr" + "ipt type='text/javascript' src='" + "http" + (window.location.protocol.indexOf('https:') == 0 ? 's' : '') + "://" + gDomain + "/" + gDcsId + "/wtid.js" + "'><\\/scr" + "ipt>");
  }
  var detectedLocale = 'en-us';
  var wtsp = 'msdnlib_dotnet';
  var gTrackEvents = '0';
/*]]>*/
</script><noscript><div><img alt="DCSIMG" id="Img1" width="1" height="1" src="http://m.webtrends.com/dcsmgru7m99k7mqmgrhudo0k8_8c6m/njs.gif?dcsuri=/nojavascript&amp;WT.js=No" /></div></noscript></div><div class="OmnitureContainer"><script type="text/javascript">
  var omni_guid = '07e1b578-dbcc-4eff-8011-54ce0983b0ff'; 
</script><noscript><a href="http://www.omniture.com" title="Web Analytics"><img src="//msstonojsmsdn.112.2o7.net/b/ss/msstonojsmsdn/1/H.20.2--NS/0" height="1" width="1" border="0" alt="" /></a></noscript></div><div class="WebMetrixContainer"><div class="MetricsContainer"><img alt="Page view tracker" src="memoryMappedFiles_elemei/trans_pixel.gif" border="0" height="0" width="0"></div></div></div><script language="javascript" type="text/javascript" src="memoryMappedFiles_elemei/broker.js"></script><script type="text/javascript" src="memoryMappedFiles_elemei/3f9eeceb05dc38c29132243d6466cee6.js" xmlns="http://www.w3.org/1999/xhtml"></script><script src="memoryMappedFiles_elemei/broker-config.js"></script></body></html>