import { View, Text, FlatList, Image } from "react-native";
import { useNavigation, useRouter, useLocalSearchParams } from "expo-router";
import { productInfo } from "@/lib/appwrite";
import useAppwrite from "../../lib/useAppwrite";
import { SafeAreaView } from "react-native-safe-area-context";

import ProductDetail from "../../components/ProductDetail";

export default function Product() {
  const navigation = useNavigation();
  const router = useRouter();
  const params = useLocalSearchParams();

  const { product } = params;

  const { data: posts, refetch } = useAppwrite(
    () => productInfo(product));

  return (
    <SafeAreaView className='h-full '>
      <FlatList
      data={posts}
      keyExtractor={(item) => item.$id}
      renderItem={({ item }) => (
        <ProductDetail 
            nome={item.nome}
            foto={item.foto}
            preco={item.preco}
            descricao={item.descricao}
            productId={item.$id}
          />
      )}
      >

      </FlatList>
    </SafeAreaView>
  );
}