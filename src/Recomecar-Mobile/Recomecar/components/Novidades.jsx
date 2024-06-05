import { View, Text, FlatList, ImageBackground, Image, TouchableOpacity } from 'react-native'
import * as Animatable from 'react-native-animatable'
import { useState } from 'react'

const zoomIn = {
  0: {
    scale: 0.7,
  },
  1: {
    scale: 1,
  },
}

const zoomOut = {
  0: {
    scale: 1,
  },
  1: {
    scale: 0.7,
  },
}

const NewProductItem = ({ activeItem, item}) => {
    
  return(
    <Animatable.View
      className='mr-5'
      animation={activeItem === item.$id ? zoomIn : zoomOut}
      duration={500}
    >

      <TouchableOpacity className='relative justify-center items-center bg-secondary-200 rounded-xl p-1' activeOpacity={0.7}>

      <Text className='text-white w-[70%] text-center'>{item.nome}</Text>

        <Image
          source={{ uri: item.foto }}
          className='w-52 h-52 rounded-xl my-3 overflow-hidden shadow-lg shadow-black/40'
          resizeMode='cover'
        />

      <Text className=' mb-2 px-2 bg-white rounded-lg'>R${item.preco}</Text>

      </TouchableOpacity>

    </Animatable.View>
  )
}

const Novidades = ({ posts }) => {
  const [activeItem, setActiveItem] = useState(posts[0]);

  const viewableItemsChanged = ({ viewableItems }) => {
    if (viewableItems.length > 0) {
      setActiveItem(viewableItems[0].key);
    }
  };

  return (
    <FlatList
        data={posts}
        keyExtractor={(item) => item.$id}
        renderItem={({ item }) => (
          <NewProductItem
            activeItem={activeItem}
            item={item}
          />
        )}
        horizontal
        onViewableItemsChanged={viewableItemsChanged}
        viewabilityConfig={{
          itemVisiblePercentThreshold: 70,
        }}
        contentOffset={{ x: 170 }}
    />
  )
}

export default Novidades