build:
	cd mvc && docker build $(options) -t web-dotnetcore:latest .

run:
	docker compose up --remove-orphans $(options)

cleanup:
	docker-compose down --remove-orphans
	docker images prune
	DangImages=($$(docker images -f "dangling=true" -q)) && if [ $${#DangImages[*]} -gt 0 ]; then docker rmi $${DangImages[@]}; fi