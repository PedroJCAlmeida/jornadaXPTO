<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>

    <xsl:template match="/">
		<div class="col-lg-3 col-sm-6 p-0">
			<div class="soccer-item set-bg" data-setbg="{/rss/channel/item[1]/enclosure/@url}" alt="">
				<div class="si-tag">
					<span>
						<xsl:value-of select="/rss/channel/item[1]/category" disable-output-escaping="yes"/> - New
					</span>
				</div>
				<div class="si-text">
					<h5 >
						<a href="{/rss/channel/item[1]/link}" target="_blank" >
							<xsl:value-of select="/rss/channel/item[1]/title" disable-output-escaping="yes"/>
						</a>
					</h5>
					<ul>
						<li>
							<a href="{/rss/channel/item[1]/link}" target="_blank" >
								<i class="fa fa-calendar"></i>
								<xsl:value-of select="/rss/channel/item[1]/pubDate" disable-output-escaping="yes"/>
							</a>
						</li>
					</ul>
				</div>
			</div>
		</div>
		<div class="col-lg-3 col-sm-6 p-0">
			<div class="soccer-item set-bg" data-setbg="{/rss/channel/item[2]/enclosure/@url}" alt="">
				<div class="si-tag">
					<span>
						<xsl:value-of select="/rss/channel/item[2]/category" disable-output-escaping="yes"/>
					</span>
				</div>
				<div class="si-text">
					<h5 >
						<a href="{/rss/channel/item[2]/link}" target="_blank" >
							<xsl:value-of select="/rss/channel/item[2]/title" disable-output-escaping="yes"/>
						</a>
					</h5>
					<ul>
						<li>
							<a href="{/rss/channel/item[2]/link}" target="_blank" >
								<i class="fa fa-calendar"></i>
								<xsl:value-of select="/rss/channel/item[2]/pubDate" disable-output-escaping="yes"/>
							</a>
						</li>
					</ul>
				</div>
			</div>
		</div>
		<div class="col-lg-3 col-sm-6 p-0">
			<div class="soccer-item set-bg" data-setbg="{/rss/channel/item[3]/enclosure/@url}" alt="">
				<div class="si-tag">
					<span>
						<xsl:value-of select="/rss/channel/item[3]/category" disable-output-escaping="yes"/>
					</span>
				</div>
				<div class="si-text">
					<h5 >
						<a href="{/rss/channel/item[3]/link}" target="_blank" >
							<xsl:value-of select="/rss/channel/item[3]/title" disable-output-escaping="yes"/>
						</a>
					</h5>
					<ul>
						<li>
							<a href="{/rss/channel/item[3]/link}" target="_blank" >
								<i class="fa fa-calendar"></i>
								<xsl:value-of select="/rss/channel/item[3]/pubDate" disable-output-escaping="yes"/>
							</a>
						</li>
					</ul>
				</div>
			</div>
		</div>
		<div class="col-lg-3 col-sm-6 p-0">
			<div class="soccer-item set-bg" data-setbg="{/rss/channel/item[4]/enclosure/@url}" alt="">
				<div class="si-tag">
					<span>
						<xsl:value-of select="/rss/channel/item[4]/category" disable-output-escaping="yes"/>
					</span>
				</div>
				<div class="si-text">
					<h5 >
						<a href="{/rss/channel/item[4]/link}" target="_blank" >
							<xsl:value-of select="/rss/channel/item[4]/title" disable-output-escaping="yes"/>
						</a>
					</h5>
					<ul>
						<li>
							<a href="{/rss/channel/item[4]/link}" target="_blank" >
								<i class="fa fa-calendar"></i>
								<xsl:value-of select="/rss/channel/item[4]/pubDate" disable-output-escaping="yes"/>
							</a>
						</li>
					</ul>
				</div>
			</div>
		</div>
		<div class="col-lg-3 col-sm-6 p-0">
			<div class="soccer-item set-bg" data-setbg="{/rss/channel/item[5]/enclosure/@url}" alt="">
				<div class="si-tag">
					<span>
						<xsl:value-of select="/rss/channel/item[5]/category" disable-output-escaping="yes"/>
					</span>
				</div>
				<div class="si-text">
					<h5 >
						<a href="{/rss/channel/item[5]/link}" target="_blank" >
							<xsl:value-of select="/rss/channel/item[5]/title" disable-output-escaping="yes"/>
						</a>
					</h5>
					<ul>
						<li>
							<a href="{/rss/channel/item[5]/link}" target="_blank" >
								<i class="fa fa-calendar"></i>
								<xsl:value-of select="/rss/channel/item[5]/pubDate" disable-output-escaping="yes"/>
							</a>
						</li>
					</ul>
				</div>
			</div>
		</div>
		<div class="col-lg-3 col-sm-6 p-0">
			<div class="soccer-item set-bg" data-setbg="{/rss/channel/item[6]/enclosure/@url}" alt="">
				<div class="si-tag">
					<span>
						<xsl:value-of select="/rss/channel/item[6]/category" disable-output-escaping="yes"/>
					</span>
				</div>
				<div class="si-text">
					<h5 >
						<a href="{/rss/channel/item[6]/link}" target="_blank" >
							<xsl:value-of select="/rss/channel/item[6]/title" disable-output-escaping="yes"/>
						</a>
					</h5>
					<ul>
						<li>
							<a href="{/rss/channel/item[6]/link}" target="_blank" >
								<i class="fa fa-calendar"></i>
								<xsl:value-of select="/rss/channel/item[6]/pubDate" disable-output-escaping="yes"/>
							</a>
						</li>
					</ul>
				</div>
			</div>
		</div>
		<div class="col-lg-3 col-sm-6 p-0">
			<div class="soccer-item set-bg" data-setbg="{/rss/channel/item[7]/enclosure/@url}" alt="">
				<div class="si-tag">
					<span>
						<xsl:value-of select="/rss/channel/item[7]/category" disable-output-escaping="yes"/>
					</span>
				</div>
				<div class="si-text">
					<h5 >
						<a href="{/rss/channel/item[7]/link}" target="_blank" >
							<xsl:value-of select="/rss/channel/item[7]/title" disable-output-escaping="yes"/>
						</a>
					</h5>
					<ul>
						<li>
							<a href="{/rss/channel/item[7]/link}" target="_blank" >
								<i class="fa fa-calendar"></i>
								<xsl:value-of select="/rss/channel/item[7]/pubDate" disable-output-escaping="yes"/>
							</a>
						</li>
					</ul>
				</div>
			</div>
		</div>
		<div class="col-lg-3 col-sm-6 p-0">
			<div class="soccer-item set-bg" data-setbg="{/rss/channel/item[8]/enclosure/@url}" alt="">
				<div class="si-tag">
					<span>
						<xsl:value-of select="/rss/channel/item[8]/category" disable-output-escaping="yes"/>
					</span>
				</div>
				<div class="si-text">
					<h5 >
						<a href="{/rss/channel/item[8]/link}" target="_blank" >
							<xsl:value-of select="/rss/channel/item[8]/title" disable-output-escaping="yes"/>
						</a>
					</h5>
					<ul>
						<li>
							<a href="{/rss/channel/item[8]/link}" target="_blank" >
								<i class="fa fa-calendar"></i>
								<xsl:value-of select="/rss/channel/item[8]/pubDate" disable-output-escaping="yes"/>
							</a>
						</li>
					</ul>
				</div>
			</div>
		</div>
    </xsl:template>
</xsl:stylesheet>
