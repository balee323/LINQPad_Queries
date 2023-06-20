<Query Kind="Expression" />

//URI verifier:


/*

\b some text  -> this is a boundry

regex: (\bhttp[s]?:\/\/){0,1}([\w]{1,}[.]{1})+([[A-Z]{2,})([\w\d\/.?=&#-]*)
*there are 4 capture groups here

([\w]{1,}[.]{1})+  -> means this capture group can go back 1 or unlimited times


will not work with:
gogg.c
google.2
google.2c

works with all these urls:
http://stackoverflow2.com/questions/30526714/seo-and-user-friendly-urls-for-multi-language-website
google.d.com
http://2.com
d.com
d2.com
https://www.facebook.com/fakeuser
http://example.com/
https://www.example.net/
http://www.example.com/
https://berry.example.com/
https://base.example.com/
http://example.com/
https://www.example.com/attack/beef
https://www.example.com/afterthought?beef=ball
http://www.example.com/?board=bikes&bear=bee
https://www.example.org/
https://example.com/
http://www.example.com/
https://example.com/branch/beef.aspx
https://www.example.com/authority.php
https://example.org/airplane.aspx
http://www.example.org/badge/amusement.php
http://example.com/
http://www.example.com/boy#bone
https://www.example.com/
https://example.com/?basketball=babies&books=advertisement
https://blood.example.com/?bit=bells
http://example.com/boy
http://www.example.com/basket/base.html
https://www.example.net/
https://www.example.com/
https://www.example.com/
https://www.example.com/behavior.html
https://bells.example.com/
https://example.com/bit/boat.aspx
https://army.example.com/boundary/base
https://example.com/beds.html
https://amount.example.com/?bit=actor
http://www.example.com/
https://example.net/basin#bird
https://www.example.com/
http://www.example.net/basket.html
https://www.example.com/arm/alarm
http://acoustics.example.org/beginner.php
http://www.example.com/
https://www.example.com/bird?adjustment=amusement
https://www.example.com/air/birds?bomb=blow
https://www.example.com/#bee
http://example.com/
http://example.net/?boot=branch
https://www.example.net/#baby
https://example.com/afterthought.html
https://www.example.com/birthday/adjustment.html
http://example.net/branch.php?behavior=airplane&board=basket
http://www.example.com/
http://example.com/?bells=bridge&attack=blade
https://www.example.com/
https://www.example.com/#bait
https://example.com/?boy=arithmetic&base=ball
http://www.example.com/
https://example.com/branch.html#amusement
http://www.example.com/believe?attack=breath
https://example.com/belief/bedroom
http://example.com/?brick=agreement
http://example.com/argument.html
https://www.example.com/
https://www.example.com/?bikes=bite&book=book
https://birth.example.com/acoustics/birds.php
http://www.example.net/
https://beds.example.com/?bedroom=aftermath&afternoon=bird
https://www.example.com/
https://www.example.com/
https://www.example.com/
http://example.net/#birth
https://example.com/
http://example.com/boundary/brother
https://example.com/
http://example.com/
http://example.com/behavior
http://www.example.com/
https://airplane.example.com/
http://www.example.org/
https://www.example.com/
http://bells.example.net/amusement
http://www.example.edu/
https://bee.example.com/blood/advertisement.php
https://example.com/bridge.aspx#afternoon
http://example.com/bee/branch.aspx
http://example.org/activity/apparel
http://addition.example.com/
http://bridge.example.com/#behaviory
https://www.example.com/blade/bead
https://www.example.com/?aunt=bit
http://www.example.net/
https://www.example.com/
http://www.example.com/battle
http://www.example.com/
http://example.com/
https://www.example.com/
http://www.example.com/arch.php?basket=bed
http://example.com/bed.aspx?argument=baseball&activity=boat
Https://www.google.com
www.google.com
google.com
www.google.sup
google.com
www.sup.com
shoe.tv
google.co






*/