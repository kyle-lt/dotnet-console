#!/bin/bash

docker rm -f dotnetconsole

docker run -d --env APPDYNAMICS_AGENT_REUSE_NODE_NAME=true \
	--env APPDYNAMICS_AGENT_REUSE_NODE_NAME_PREFIX=dotnet-console \
	--name dotnetconsole kjtully/dotnetconsole:20.6 

exit 0
