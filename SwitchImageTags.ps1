# docker rmi -f $(docker images *moment* -q)
# docker rmi -f $(docker images */*moment* -q)

docker images

$version = '0.1.0'
$targetVersion = 'staging'

docker tag momentservicesapicustomer:$version 958301269065.dkr.ecr.us-east-2.amazonaws.com/momentservicesapicustomer:$targetVersion
docker push 958301269065.dkr.ecr.us-east-2.amazonaws.com/momentservicesapicustomer:$targetVersion

docker tag momentservicesapibusiness:$version 958301269065.dkr.ecr.us-east-2.amazonaws.com/momentservicesapibusiness:$targetVersion
docker push 958301269065.dkr.ecr.us-east-2.amazonaws.com/momentservicesapibusiness:$targetVersion

docker tag momentservicesdaemon:$version 958301269065.dkr.ecr.us-east-2.amazonaws.com/momentservicesdaemon:$targetVersion
docker push 958301269065.dkr.ecr.us-east-2.amazonaws.com/momentservicesdaemon:$targetVersion

