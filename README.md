# Otil
All in one system diagnostics utility

Written in C#

Data flow:
* Scrapers initialize via a singleton design pattern and begin to async scrape
* Listeners (UI User Controls) register to the scrapers as listeners
* On completion of a single scrape of the relevant hardware, the scraper updates all listeners
* UI updates via defers

TODO:
* CLEAN THE REPO
* Per process network use
* Optimise processes and services refresh redraws
* Network wan/lan differenciation
* Network per process limits (like netlimiter)
* Speedfan functionality
* Overlay functionality (dx and opengl hooks)
* Mobile app with a https server
* Maybe turn it into a library/microservice with a web front end (bootstrap, angular, react, etc.)
