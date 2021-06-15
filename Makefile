build:
	cd mvc/client && npm install && ng build --configuration development
	cd mvc && docker build $(options) -t web-dotnetcore:latest .

run:
	docker compose up $(options) --remove-orphans

cleanup:
	docker-compose down --remove-orphans
	docker images prune
	DangImages=($$(docker images -f "dangling=true" -q)) && if [ $${#DangImages[*]} -gt 0 ]; then docker rmi $${DangImages[@]}; fi