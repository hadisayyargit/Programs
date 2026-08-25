const staticCacheName = "site-static-v1";
const cacheAssets = [
    "/",    
    "/shared/_Layout.cshtml",
    "/home/index.cshtml",
    "/content/style.css",
    "/scripts/theme.js",
    "/assets/images/cup/cup1.png",
    "/ReportViewerPage.aspx"
];

self.addEventListener("install", evt => {
    evt.waitUntil(
        caches
            .open(staticCacheName)
            .then(cache => {
                console.log("caching assets...");
                cache.addAll(cacheAssets);
            })
            .catch(err => { })
    );
});

self.addEventListener('activate', () => {
    // Perform activate steps. e.g. managing caches etc.
});

//self.addEventListener("fetch", evt => {
//    evt.respondWith(
//        caches
//            .match(evt.request)
//            .then(res => {
//                return res || fetch(evt.request);
//            })
//            .catch(err => {
//                if (evt.request.url.indexOf(".cshtml") > -1) {
//                    return caches.match("/views/home/index.cshtml");
//                }
//            })
//    );
//});

//self.addEventListener('fetch', event => {
//    const { request } = event;
//    const findResponsePromise = caches.open(CACHE_NAME)
//        .then(cache => cache.match(request))
//        .then(response => {
//            if (response) {
//                return response;
//            }

//            return fetch(request);
//        });

//    event.respondWith(findResponsePromise);
//});

self.addEventListener('fetch', function (event) {
    event.respondWith(
        caches.match(event.request)
            .then(function (response) {
                if (response) {
                    return response;
                }
                return fetch(event.request);
            }
            )
    );
});