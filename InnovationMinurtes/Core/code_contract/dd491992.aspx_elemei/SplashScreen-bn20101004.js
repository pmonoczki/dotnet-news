

if(!window.Microsoft)var Microsoft={};if(!Microsoft.Mtps)Microsoft.Mtps={};if(!Microsoft.Mtps.Silverlight)Microsoft.Mtps.Silverlight={};if(!Microsoft.Mtps.Silverlight.SplashScreensLoaded)Microsoft.Mtps.Silverlight.SplashScreensLoaded=[];Microsoft.Mtps.Silverlight.Color="#FF06a4de";Microsoft.Mtps.Silverlight.SplashScreenProgress=.3;Microsoft.Mtps.Silverlight.OnSourceDownloadProgressChanged=function(sender,e){Microsoft.Mtps.Silverlight.SourceDownloadProgressChanged(sender,e.progress?e.progress:e.get_progress())};Microsoft.Mtps.Silverlight.SetProgress=function(host,progress){Microsoft.Mtps.Silverlight.SplashScreensLoaded[host]=" "+Math.round(progress*1000)};Microsoft.Mtps.Silverlight.SourceDownloadProgressChanged=function(sender,progress){var host=sender.GetHost(),xLoadingArea=sender.findName("xLoadingArea"),xProgressBarSize=sender.findName("xProgressBarSize"),xProgressBarSizeWidth=sender.findName("xProgressBarSizeWidth"),xProgressBar2Size=sender.findName("xProgressBar2Size"),xProgressBar2SizeWidth=sender.findName("xProgressBar2SizeWidth"),xProgressBar2SizeLeft=sender.findName("xProgressBar2SizeLeft"),xProgressBarContainer=sender.findName("xProgressBarContainer"),xProgressBar=sender.findName("xProgressBar"),xProgressBar2=sender.findName("xProgressBar2"),xProgressBarText=sender.findName("xProgressBarText");progress=progress*Microsoft.Mtps.Silverlight.SplashScreenProgress;Microsoft.Mtps.Silverlight.SetProgress(host,progress);var progressBarMaxWidth=xProgressBarContainer.ActualWidth-2;xProgressBarSizeWidth.Value=Math.round(progressBarMaxWidth*progress);xProgressBarSize.Begin();xProgressBar2SizeWidth.Value=Math.round((1-progress)*progressBarMaxWidth);xProgressBar2SizeLeft.Value=Math.round(progressBarMaxWidth*progress)+2;xProgressBar2Size.Begin();xProgressBarText.Text=Math.round(progress*100)+" percent";Microsoft.Mtps.Silverlight.AlignRight(xProgressBarText,xLoadingArea);Microsoft.Mtps.Silverlight.SetProgress(sender.GetHost(),progress)};Microsoft.Mtps.Silverlight.OnSourceDownloadComplete=function(sender,e){var xProgressBarContainer=sender.findName("xProgressBarContainer"),xProgressBar=sender.findName("xProgressBar"),progressBarMaxWidth=xProgressBarContainer.ActualWidth-2};MCWCSilverlightOnSplashScreenLoaded=Microsoft.Mtps.Silverlight.OnSplashScreenLoaded=function(sender){var host=sender.GetHost();host.OnSourceDownloadProgressChanged=Microsoft.Mtps.Silverlight.OnSourceDownloadProgressChanged;host.OnSourceDownloadComplete=Microsoft.Mtps.Silverlight.OnSourceDownloadComplete;var width=host.offsetWidth/1,height=host.offsetHeight/1,xProgressBar=sender.findName("xProgressBar");xProgressBar.Fill=Microsoft.Mtps.Silverlight.Color;var xProgressBarText=sender.findName("xProgressBarText");xProgressBarText.Foreground=Microsoft.Mtps.Silverlight.Color;var xLayoutRoot=sender.findName("xLayoutRoot");xLayoutRoot.Width=width;xLayoutRoot.Height=height;var xLoadingArea=sender.findName("xLoadingArea");xLoadingArea.Opacity=0;Microsoft.Mtps.Silverlight.AlignCenter(xLoadingArea,xLayoutRoot);Microsoft.Mtps.Silverlight.AlignMiddle(xLoadingArea,xLayoutRoot);Microsoft.Mtps.Silverlight.SourceDownloadProgressChanged(sender,0);var xLoadingShow=sender.findName("xLoadingShow");xLoadingShow.Begin();var xLoadingProgress=sender.findName("xLoadingProgress");xLoadingProgress.Begin()};Microsoft.Mtps.Silverlight.AlignRight=function(child,parent){child.SetValue("Canvas.Left",parent.Width-child.ActualWidth)};Microsoft.Mtps.Silverlight.AlignCenter=function(child,parent){child.SetValue("Canvas.Left",Math.round(parent.Width/2-child.ActualWidth/2))};Microsoft.Mtps.Silverlight.AlignMiddle=function(child,parent){child.SetValue("Canvas.Top",Math.round(parent.Height/2-child.ActualHeight/2))};Microsoft.Mtps.Silverlight.IsSplashScreenLoaded=function(plugin){return Microsoft.Mtps.Silverlight.SplashScreensLoaded[plugin]}

