﻿var myCenter = new google.maps.LatLng(49.82, 19.0240);
function ViewModel(busStops) {
    var self = this;

    self.busStops = busStops;

    function initialize() {
        var mapProp = {
            center: myCenter,
            zoom: 12,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        };

        var map = new google.maps.Map(document.getElementById("googleMap"), mapProp);

        var path = [];
        for (var i = 0; i < viewModel.busStops.length; i++) {

            var busStop = new google.maps.LatLng(viewModel.busStops[i].gpsLat, viewModel.busStops[i].gpsLng);
            var marker = new google.maps.Marker({
                position: busStop,
            });
            path.push(busStop);

            marker.setMap(map);
        }

        var busPath = new google.maps.Polyline({
            path: path,
            strokeColor: "#0000FF",
            strokeOpacity: 0.8,
            strokeWeight: 2

        });
        busPath.setMap(map);
    }

    google.maps.event.addDomListener(window, 'load', initialize);
};
