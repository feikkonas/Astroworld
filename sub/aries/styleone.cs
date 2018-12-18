@font-face {
  font-family: 'Gotham-ExtraLight';
  /*a name to be used later*/
  src: url("file:///C:/Users/korin/Desktop/tree/subpage/img/Gotham%20Extra%20Light.otf");
  /*URL to font*/ }
body {
  background-image: url(../img/background.jpg);
  top: 0;
  width: 100%;
  z-index: 0;
  height: 100%;
  background-size: calc(100% + 50px);
  color: #ffffff;
  background-attachment: fixed;
  font-family: "Gotham-ExtraLight";
  display: grid;
  grid-template-columns: repeat(12, 1fr);
  grid-template-rows: 200px 1450px 1000px;
  grid-template-areas: "hd hd hd hd hd hd hd hd hd hd hd hd" "mn mn mn mn mn mn mn mn mn mn mn mn" "ft ft ft ft ft ft ft ft ft ft ft ft"; }

header {
  grid-area: hd; }

.logo {
  height: 150px;
  position: fixed; }

.logo:hover {
  filter: blur(1px); }

#title {
  position: fixed;
  font-size: 40px;
  left: 45%;
  top: 1%; }

#date {
  position: absolute;
  font-size: 30px;
  left: 42%;
  top: 15%;
  color: #ffffff;
  border-top: #ffffff91 inset 2px;
  padding: 10px; }

#svg {
  height: 400px;
  position: fixed;
  top: 25%;
  left: 20%;
  opacity: 0.3; }

.scroll {
  background: url(../img/scrolll.png);
  background-repeat: no-repeat;
  height: 400px;
  width: 64px;
  z-index: 100;
  position: absolute;
  top: 20%;
  left: 90%; }

@keyframes play {
  from {
    background-position: 8px; }
  to {
    background-position: -770px; } }
.scroll {
  animation: play 6s steps(7); }

/* make stars moving a little (scaling)*/
main {
  grid-area: mn; }

#youtube {
  position: absolute;
  left: 15%;
  top: 130%;
  border: #ffffff solid 1px; }

#borderbuttom {
  z-index: 100;
  height: 100px;
  position: absolute;
  top: 204%;
  left: 25%; }

footer {
  grid-area: ft; }

img {
  position: absolute; }

p {
  position: absolute; }

.title-s {
  font-size: 30px;
  top: 250%;
  left: 18%;
  border-bottom: #ffffff91 solid 1px;
  border-top: #ffffff91 solid 1px;
  padding: 5px; }

.title-e {
  font-size: 30px;
  top: 250%;
  left: 47%;
  border-bottom: #ffffff91 solid 1px;
  border-top: #ffffff91 solid 1px;
  padding: 5px; }

.title-p {
  font-size: 30px;
  top: 250%;
  left: 73%;
  border-bottom: #ffffff91 solid 1px;
  border-top: #ffffff91 solid 1px;
  padding: 5px; }

.text-s {
  font-size: 20px;
  top: 311%;
  left: 11%;
  border-bottom: 0;
  border-top: #ffffff91 solid 1px;
  padding: 30px; }

.text-e {
  font-size: 30px;
  top: 310%;
  left: 49%;
  border-bottom: 0;
  border-top: #ffffff91 solid 1px;
  padding: 20px; }

.text-p {
  font-size: 30px;
  top: 310%;
  left: 74%;
  border-bottom: 0;
  border-top: #ffffff91 solid 1px;
  padding: 20px; }

.symbol {
  height: 200px;
  top: 270%;
  left: 10%; }

.element {
  height: 200px;
  top: 270%;
  left: 43%; }

.planet {
  height: 200px;
  top: 270%;
  left: 70%; }

.strenghts {
  top: 350%;
  left: 10%;
  height: 0;
  font-size: 20px; }

.weaknesses {
  top: 380%;
  left: 10%;
  height: 0;
  font-size: 20px; }

.likes {
  top: 350%;
  left: 60%;
  height: 0;
  font-size: 20px; }

.dislikes {
  top: 380%;
  left: 60%;
  height: 0;
  font-size: 20px; }

.line {
  top: 345%;
  left: 52%;
  height: 400px;
  font-size: 0;
  opacity: 0.5; }

@media screen and (max-width: 600px) {
  body {
    grid-template-columns: 1fr;
    grid-template-rows: 300px 400px 200px;
    grid-template-areas: "hd" "mn" "ft";
    background-image: url(../img/backgroundturn.jpg);
    background-attachment: scroll; }

  .logo {
    height: 100px;
    left: 35%; }

  #title {
    font-size: 40px;
    left: 30%;
    top: 10%;
    position: absolute; }

  #date {
    font-size: 20px;
    top: 25%;
    left: 29%; }

  #svg {
    height: 200px;
    top: 45%;
    left: 10%; } }

/*# sourceMappingURL=styleone.cs.map */
