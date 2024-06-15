import { View, Text } from "react-native";

const InfoBox = ({ title, containerStyles, titleStyles }) => {
  return (
    <View className={containerStyles}>
      <Text className={`text-2xl font-psemibold ${titleStyles}`}>
        {title}
      </Text>
    </View>
  );
};

export default InfoBox;
