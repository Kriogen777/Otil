# Otil
All in one system diagnostics utility

[Download Here](http://otil.sourceforge.net/)

Written in C#

Data flow:
* Scrapers initialize via a singleton design pattern and begin to async scrape
* Listeners (UI User Controls) register to the scrapers as listeners
* On completion of a single scrape of the relevant hardware, the scraper updates all listeners
* UI updates via defers
