#!/bin/bash
cd /git/blog
git pull
hugo --theme=hyde -b https://holdengong.com/
cp -rf /git/blog/public/. /www/wwwroot/www.holdengong.com/