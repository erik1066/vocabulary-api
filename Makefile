docker-build:
	docker build \
		-t vocabulary-api \
		--rm \
		--force-rm=true \
		--build-arg VOCABULARY_PORT=9090 \
		.

docker-run: docker-start
docker-start:
	# docker-compose up --detach
	docker run -d \
		-p 9090:9090 \
		--name=vocabulary-api_main \
		vocabulary-api

docker-stop:
	docker stop vocabulary-api_main || true
	docker rm vocabulary-api_main || true
	# docker-compose down --volume

docker-restart:
	make docker-stop 2>/dev/null || true
	make docker-start


# *************************
# *        testing        *
# *************************

# Unit tests
run-unit-tests:
	docker build \
		-t vocabulary-api-tests \
		-f tests/unit/Dockerfile.test \
		--rm \
		--force-rm=true \
		.
	docker rmi vocabulary-api-tests

# Integration tests
### TODO: Add

# Performance tests
### TODO: Add

# Security tests
### TODO: Add

# SonarQube
# sonar-up:
# 	docker pull sonarqube
# 	docker run -d --name sonarqube -p 9000:9000 -p 9092:9092 sonarqube || true

# sonar-run: sonar-start
# sonar-start:
# 	printf 'Wait for sonarqube\n'
# 	until `curl --output /dev/null --silent --head --fail --connect-timeout 80 http://localhost:9000/api/server/version`; do printf '.'; sleep 1; done
# 	sleep 5
# 	docker-compose up --detach
# 	dotnet tool install --global dotnet-sonarscanner || true
# 	dotnet sonarscanner begin /k:"vocabulary-api" || true
# 	dotnet test --collect:"Code Coverage"
# 	dotnet sonarscanner end || true
# 	docker-compose down --volume

# sonar-stop: sonar-down
# sonar-down:
# 	docker kill sonarqube || true
# 	docker rm sonarqube || true