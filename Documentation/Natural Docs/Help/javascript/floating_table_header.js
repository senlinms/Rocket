﻿var NDWFloatingTableHeader=new function(){this.Start=function(headerRowID,lastContentRowID){this.siteHeader=document.getElementById("SiteHeader");this.headerRow=document.getElementById(headerRowID);this.headerCells=this.headerRow.getElementsByTagName("TH");this.lastContentRow=document.getElementById(lastContentRowID);window.addEventListener("scroll",function(){NDWFloatingTableHeader.Update();});window.addEventListener("resize",function(){NDWFloatingTableHeader.Update();});this.Update();};this.Update=function(){var siteHeaderHeight=this.siteHeader.offsetHeight;var windowScroll=(window.pageYOffset||0);var headerRowTop=NDWShared.OffsetTopFromBody(this.headerRow);var headerRowHeight=this.headerRow.offsetHeight;var lastContentRowTop=NDWShared.OffsetTopFromBody(this.lastContentRow);var headerWindowOffset=headerRowTop-windowScroll;var adjustment=0;if(headerWindowOffset<siteHeaderHeight){adjustment=siteHeaderHeight-headerWindowOffset;if(headerRowTop+headerRowHeight+adjustment>lastContentRowTop){adjustment=lastContentRowTop-headerRowHeight-headerRowTop;}}for(var i=0;i<this.headerCells.length;i++){this.headerCells[i].style.top=adjustment+"px";}};};